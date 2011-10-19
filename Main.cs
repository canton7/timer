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

		public Main() {
			InitializeComponent();

			this.tasks.Add(new Task("GDP", "Some Task", 0));

			this.populateProjects();
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
					this.buttonSave.Enabled = true;
					break;
				case Task.States.IN_PROGRESS:
					this.buttonStartStop.Text = "Stop";
					this.buttonPause.Enabled = true;
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
			int duration = (this.dateTimePickerDuration.Value.Hour * 60 + this.dateTimePickerDuration.Value.Minute) * 60;

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

		private void timer_Tick(object sender, EventArgs e) {
			if (!this.haveCurrentTask) {
				this.timer.Stop();
				return;
			}
			this.labelDuration.Text = this.currentTask.Duration.ToString("hh':'mm':'ss");
		}
    }
}
