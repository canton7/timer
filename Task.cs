using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace timer {
	class Task {
		public enum States { NEW, IN_PROGRESS, PAUSED, FINISHED };
		private States state;

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

		public Task() {
			// Used to create a new task
			this.state = States.FINISHED;
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
