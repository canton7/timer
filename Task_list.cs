using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace timer {
	class TaskList {
		private List<Task> tasks = new List<Task>();
		public List<Task> Tasks {
			get { return this.tasks; }
		}

		public Task CurrentTask {
			get { return this.tasks[0]; }
		}

		public Task.States CurrentState {
			get { return this.tasks[0].State; }
		}

		public int Count {
			get { return this.tasks.Count; }
		}

		private List<string> projects = new List<string>();
		public List<string> Projects {
			get { return this.projects; }
		}
		public string CurrentProject {
			get { return (this.tasks.Count > 0) ? this.tasks[0].Project : ""; }
		}

		public struct SerializedForm {
			public Task.SerializedForm[] Tasks;
		}

		public TaskList() {

		}

		public void AddTask(string project, string description, TimeSpan duration) {
			this.tasks.Insert(0, new Task(project, description, duration));
			if (!this.projects.Contains(project))
				this.projects.Add(project);
		}

		public void StartCurrent() {
			this.tasks[0].Start();
		}

		public void FinishCurrent() {
			this.tasks[0].Finish();
		}

		public void PauseCurrent() {
			this.tasks[0].Pause();
		}

		public void ResumeCurrnt() {
			this.tasks[0].Resume();
		}

		public SerializedForm Serialize() {
			SerializedForm serializedForm = new SerializedForm();
			List<Task.SerializedForm> tasks = new List<Task.SerializedForm>();
			foreach (Task task in this.tasks) {
				tasks.Add(task.Serialize());
			}
			serializedForm.Tasks = tasks.ToArray();
			return serializedForm;
		}
	}
}
