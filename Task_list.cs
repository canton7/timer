﻿using System;
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

		// Cache of duration for all tasks in current project except current task
		private TimeSpan currentProjectFinishedTime;
		public TimeSpan CurrentProjectTime {
			get { return this.currentProjectFinishedTime + this.tasks[0].Duration; }
		}

		public class SerializedForm {
			public Task.SerializedForm[] Tasks;
		}

		public TaskList() {
		}

		public TaskList(SerializedForm serializedForm) {
			if (serializedForm == null)
				return;
			this.Unserialize(serializedForm);
			foreach (Task task in this.tasks) {
				if (!this.projects.Contains(task.Project))
					this.projects.Add(task.Project);
			}
			this.currentProjectFinishedTime = this.calcCurrentProjectFinishedTime();
		}

		public void AddTask(string project, string description, TimeSpan duration) {
			// Don't replace the top-of-the-list task if it's currently running
			int index = (this.tasks[0].State == Task.States.IN_PROGRESS) ? 1 : 0;
			this.tasks.Insert(index, new Task(project, description, duration));
			if (!this.projects.Contains(project))
				this.projects.Insert(index, project);
			this.currentProjectFinishedTime = this.calcCurrentProjectFinishedTime();
		}

		public void StartCurrent() {
			this.tasks[0].Start();
		}

		public void StopCurrent() {
			this.tasks[0].Stop();
		}

		private TimeSpan calcCurrentProjectFinishedTime() {
			TimeSpan timespan = new TimeSpan(0);
			foreach (Task task in this.tasks) {
				if (task.Project != this.CurrentProject)
					continue;
				// Don't include current task, as this is updated so can't be cached
				if (task == this.tasks[0])
					continue;
				timespan += task.Duration;
			}
			return timespan;
		}

		public TimeSpan GetProjectTime(string project) {
			TimeSpan timespan = new TimeSpan(0);
			foreach (Task task in this.tasks) {
				if (task.Project != project)
					continue;
				timespan += task.Duration;
			}
			return timespan;
		}

		public Task[] GetProjectTasks(string project) {
			List<Task> tasks = new List<Task>();
			foreach (Task task in this.tasks) {
				if (task.Project != project)
					continue;
				tasks.Add(task);
			}
			return tasks.ToArray();
		}

		public void SetCurrentTask(Task task) {
			if (!this.tasks.Contains(task))
				throw new Exception("Can't find that task when setting it as current");

			// Take the task and stick it at the top
			this.tasks.Remove(task);
			this.tasks.Insert(0, task);
			this.currentProjectFinishedTime = this.calcCurrentProjectFinishedTime();
		}

		public void DeleteTask(Task task) {
			if (!this.tasks.Contains(task))
				throw new Exception("Can't find that task when deleteing");
			this.tasks.Remove(task);
			this.currentProjectFinishedTime = this.calcCurrentProjectFinishedTime();
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

		public void Unserialize(SerializedForm serializedForm) {
			foreach (Task.SerializedForm serializedTask in serializedForm.Tasks) {
				this.tasks.Add(new Task(serializedTask));
			}
		}
	}
}
