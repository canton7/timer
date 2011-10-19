using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace timer {
	public partial class Main : Form {
		private List<Task> tasks = new List<Task>();
		private Task currentTask {
			get {
				return this.tasks[0];
			}
		}

		private bool haveCurrentTask = false;

		public struct SerializedForm {
			public Task.SerializedForm[] Tasks;
		}

		public Main() {
			InitializeComponent();

			this.tasks.Add(new Task("GDP", "Some Task", new TimeSpan()));

			this.populateProjects();

			//string json = LitJson.JsonMapper.ToJson(new TimeSpan());
        }

		private void setButtonEnabled() {
			if (!this.haveCurrentTask) {
				this.buttonStartStop.Text = "Start";
				this.buttonPause.Enabled = false;
				this.buttonSave.Enabled = true;
				return;
			}

			switch (this.currentTask.State) {
				case Task.States.NEW:
					this.buttonStartStop.Text = "Start";
					this.buttonPause.Enabled = false;
					this.buttonPause.Text = "Pause";
					this.buttonSave.Enabled = true;
					break;
				case Task.States.IN_PROGRESS:
					this.buttonStartStop.Text = "Stop";
					this.buttonPause.Enabled = true;
					this.buttonPause.Text = "Pause";
					this.buttonSave.Enabled = false;
					break;
				case Task.States.PAUSED:
					this.buttonStartStop.Text = "Stop";
					this.buttonPause.Enabled = true;
					this.buttonPause.Text = "Resume";
					this.buttonSave.Enabled = false;
					break;
				default:
					break;
			}
		}

		private void populateProjects() {
			foreach (Task task in this.tasks) {
				if (this.comboBoxProject.Items.Contains(task.Project))
					continue;
				this.comboBoxProject.Items.Add(task.Project);
			}
			this.comboBoxProject.Text = this.tasks[0].Project;
		}

		private void createTask() {
			string project = this.comboBoxProject.Text;
			string description = this.textBoxDescription.Text;
			// in seconds
			TimeSpan duration = new TimeSpan(this.dateTimePickerDuration.Value.Hour, this.dateTimePickerDuration.Value.Minute, 0);

			this.tasks.Insert(0, new Task(project, description, duration));
		}

		private void startTask() {
			if (this.currentTask == null)
				throw new Exception("No task to start");
			this.currentTask.Start();
			this.haveCurrentTask = true;
			this.labelDuration.Text = "00:00:00";
			this.timer.Start();
			this.setButtonEnabled();
		}

		private void stopTask() {
			this.currentTask.Finish();
			this.timer.Stop();
			this.haveCurrentTask = false;
			this.setButtonEnabled();
			string json = LitJson.JsonMapper.ToJson(this.tasks[0].Serialize());
		}

		private void pauseTask() {
			this.currentTask.Pause();
			this.timer.Stop();
			this.setButtonEnabled();
		}

		private void resumeTask() {
			this.currentTask.Resume();
			this.timer.Start();
			this.setButtonEnabled();
		}

		private void buttonStartStop_Click(object sender, EventArgs e) {
			if (!this.haveCurrentTask) {
				this.createTask();
			}
			switch (this.currentTask.State) {
				case Task.States.NEW:
					this.startTask();
					break;
				case Task.States.IN_PROGRESS:
					this.stopTask();
					break;
			}
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

		private void timer_Tick(object sender, EventArgs e) {
			if (!this.haveCurrentTask) {
				this.timer.Stop();
				return;
			}
			this.labelDuration.Text = this.currentTask.Duration.ToString("hh':'mm':'ss");
		}

		private void buttonPause_Click(object sender, EventArgs e) {
			if (!this.haveCurrentTask)
				return;
			switch (this.currentTask.State) {
				case Task.States.IN_PROGRESS:
					this.pauseTask();
					break;
				case Task.States.PAUSED:
					this.resumeTask();
					break;
			}
		}
    }
}
