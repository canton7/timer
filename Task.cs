using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace timer {
	public class Task {
		//private string project;
		public string Project {
			get; set;
		}
		public string Description {
			get; set;
		}
		public bool SoundedAlarm {
			get; set;
		}

		public enum States { IN_PROGRESS, STOPPED };
		private States state;
		public States State {
			get { return this.state; }
		}

		private List<WorkTime> workTimes = new List<WorkTime>();
		public List<WorkTime> WorkTimes {
			get { return this.workTimes; }
		}

		private TimeSpan finishedDuration;

		public TimeSpan Duration {
			get { return this.finishedDuration + ((this.state == States.IN_PROGRESS && this.workTimes.Count > 0) ? DateTime.Now - this.workTimes[0].StartedAt : new TimeSpan()); }
		}

		private TimeSpan expectedTime;
		public TimeSpan ExpectedTime {
			get { return this.expectedTime; }
			set {
				// Force the alarm to go off again if we hit it
				if (value > this.Duration)
					this.SoundedAlarm = false;
				this.expectedTime = value;
			}
		}

		public struct SerializedForm {
			public string Project;
			public string Description;
			public string ExpectedTime;
			public bool SoundedAlarm;
			public WorkTime.SerializedForm[] WorkTimes;
		}

		public class WorkTime {
			public DateTime StartedAt;
			public DateTime? StoppedAt;

			public TimeSpan Duration {
				get { return this.StoppedAt.Value - this.StartedAt; }
			}

			public struct SerializedForm {
				public string StartedAt;
				public string StoppedAt;
			}

			public WorkTime() {
				this.StartedAt = DateTime.Now;
				this.StoppedAt = null;
			}
			public WorkTime(SerializedForm serializedForm) {
				this.StartedAt = DateTime.Parse(serializedForm.StartedAt);
				if (serializedForm.StoppedAt == null)
					this.StoppedAt = null;
				else
					this.StoppedAt = DateTime.Parse(serializedForm.StoppedAt);
					
			}

			public SerializedForm Serialize() {
				return new SerializedForm {
					StartedAt = this.StartedAt.ToString(),
					StoppedAt = this.StoppedAt.Value.ToString(),
				};
			}
		}

		public Task(string project, string desciption, TimeSpan expectedTime) {
			// Used to create a new task
			this.state = States.STOPPED;
			this.Project = project;
			this.Description = desciption;
			this.expectedTime = expectedTime;
			this.SoundedAlarm = (expectedTime == new TimeSpan(0) ? true : false);
		}

		public Task(SerializedForm serializedForm) {
			this.Unserialize(serializedForm);
		}

		public void Start() {
			this.state = States.IN_PROGRESS;
			this.workTimes.Insert(0, new WorkTime());
		}

		public void Stop() {
			if (this.state == States.STOPPED)
				return;
			this.state = States.STOPPED;
			this.workTimes[0].StoppedAt = DateTime.Now;
			this.finishedDuration += DateTime.Now - this.workTimes[0].StartedAt;
		}

		public void SortWorkTimes() {
			this.workTimes = this.workTimes.OrderByDescending(x => x.StartedAt).ToList();
		}

		public void DeleteWorkTime(WorkTime workTime) {
			this.workTimes.Remove(workTime);
			this.updateFinishedDuration();
		}

		public void AddWorkTime(WorkTime workTime) {
			this.workTimes.Add(workTime);
			this.SortWorkTimes();
			this.updateFinishedDuration();
		}

		public void EditWorkTime() {
			// The user is expected to edit the worktimes themselves
			this.updateFinishedDuration();
		}

		public void updateFinishedDuration() {
			this.finishedDuration = new TimeSpan(0);
			foreach (WorkTime workTime in this.workTimes) {
				this.finishedDuration += workTime.Duration;
			}
		}

		public SerializedForm Serialize() {
			SerializedForm serializedForm = new SerializedForm();
			serializedForm.Project = this.Project;
			serializedForm.Description = this.Description;
			serializedForm.ExpectedTime = this.expectedTime.ToString("hh':'mm':'ss");
			serializedForm.SoundedAlarm = this.SoundedAlarm;
			List<WorkTime.SerializedForm> workTimes = new List<WorkTime.SerializedForm>();
			foreach (WorkTime workTime in this.workTimes) {
				workTimes.Add(workTime.Serialize());
			}
			serializedForm.WorkTimes = workTimes.ToArray();
			return serializedForm;
		}

		public void Unserialize(SerializedForm serializedForm) {
			this.Project = serializedForm.Project;
			this.Description = serializedForm.Description;
			this.state = States.IN_PROGRESS;
			this.SoundedAlarm = serializedForm.SoundedAlarm;
			string[] parts = serializedForm.ExpectedTime.Split(':');
			this.expectedTime = new TimeSpan(int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
			foreach (WorkTime.SerializedForm serializedWork in serializedForm.WorkTimes) {
				this.workTimes.Add(new WorkTime(serializedWork));
			}
			this.updateFinishedDuration();
		}
	}
}
