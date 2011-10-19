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

		public Main() {
			InitializeComponent();

			this.tasks.Add(new Task("GDP", "Some Task", 0));

			this.populateProjects();
        }

		private bool haveCurrentTask() {
			return false;
		}

		private void setButtonEnabled() {
			if (!this.haveCurrentTask()) {
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
		}

		private void buttonStartStop_Click(object sender, EventArgs e) {
			if (!this.haveCurrentTask()) {
				this.createTask();
			}
			this.startTask();
		}
    }
}
