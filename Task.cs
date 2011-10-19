using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace timer {
	class Task {
		//private string project;
		public string Project {
			get; set;
		}
		public string Description {
			get; set;
		}

		public enum States { NEW, IN_PROGRESS, PAUSED, FINISHED };
		private States state;
		public States State {
			get { return this.state; }
		}

		public class WorkTime {
			public DateTime StartedAt;
			public DateTime? FinishedAt;

			public WorkTime() {
				this.StartedAt = DateTime.Now;
				this.FinishedAt = null;
			}
		}
		private List<WorkTime> workTimes = new List<WorkTime>();

		private int expectedTime;

		public Task(string project, string desciption, int expectedTime) {
			// Used to create a new task
			this.state = States.NEW;
			this.Project = project;
			this.Description = desciption;
			this.expectedTime = expectedTime;
		}

		public void Start() {
			if (this.state != States.NEW)
				throw new Exception("Can't start a task that isn't NEW");
			this.state = States.IN_PROGRESS;
			this.workTimes.Insert(0, new WorkTime());
		}

		public void Finish() {
			this.state = States.FINISHED;
			this.workTimes[0].FinishedAt = DateTime.Now;
		}

		public void Pause() {
			this.state = States.PAUSED;
			this.workTimes[0].FinishedAt = DateTime.Now;
		}

		public void Resume() {
			this.state = States.IN_PROGRESS;
			this.workTimes.Insert(0, new WorkTime());
		}
	}
}
