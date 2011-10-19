﻿using System;
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

		public enum States { IN_PROGRESS, STOPPED };
		private States state;
		public States State {
			get { return this.state; }
		}

		private List<WorkTime> workTimes = new List<WorkTime>();

		private TimeSpan finishedDuration;

		public TimeSpan Duration {
			get { return this.finishedDuration + ((this.state == States.IN_PROGRESS && this.workTimes.Count > 0) ? DateTime.Now - this.workTimes[0].StartedAt : new TimeSpan()); }
		}

		private TimeSpan expectedTime;
		public TimeSpan ExpectedTime {
			get { return this.expectedTime; }
		}

		public struct SerializedForm {
			public string Project;
			public string Description;
			public string ExpectedTime;
			public States State;
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
		}

		public Task(SerializedForm serializedForm) {
			this.Unserialize(serializedForm);
		}

		public void Start() {
			this.state = States.IN_PROGRESS;
			this.workTimes.Insert(0, new WorkTime());
		}

		public void Stop() {
			this.state = States.STOPPED;
			this.workTimes[0].StoppedAt = DateTime.Now;
			this.finishedDuration += DateTime.Now - this.workTimes[0].StartedAt;
		}

		public SerializedForm Serialize() {
			SerializedForm serializedForm = new SerializedForm();
			serializedForm.Project = this.Project;
			serializedForm.Description = this.Description;
			serializedForm.ExpectedTime = this.expectedTime.ToString("hh':'mm");
			serializedForm.State = this.state;
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
			this.state = serializedForm.State;
			string[] parts = serializedForm.ExpectedTime.Split(':');
			this.expectedTime = new TimeSpan(int.Parse(parts[0]), int.Parse(parts[1]), 0);
			foreach (WorkTime.SerializedForm serializedWork in serializedForm.WorkTimes) {
				this.workTimes.Add(new WorkTime(serializedWork));
			}

			this.finishedDuration = new TimeSpan(0);
			foreach (WorkTime workTime in this.workTimes) {
				this.finishedDuration += workTime.Duration;
			}

		}
	}
}
