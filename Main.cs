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
		private TaskList taskList;

		private bool haveCurrentTask = false;

		private FileHandler fileHandler;

		public Main() {
			InitializeComponent();
			this.fileHandler = FileHandler.Instance;

			this.taskList = new TaskList(this.fileHandler.LoadTasks());
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

			switch (this.taskList.CurrentTask.State) {
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
			this.comboBoxProject.Text = this.taskList.CurrentProject;

			this.comboBoxProject.Items.Clear();
			foreach (string project in this.taskList.Projects) {
				this.comboBoxProject.Items.Add(project);
			}
		}

		private bool createTask() {
			string project = this.comboBoxProject.Text.Trim();
			string description = this.textBoxDescription.Text.Trim();
			// in seconds
			TimeSpan duration = new TimeSpan(this.dateTimePickerDuration.Value.Hour, this.dateTimePickerDuration.Value.Minute, 0);

			if (project.Length == 0) {
				this.labelError.Text = "No Project";
				this.labelError.Visible = true;
				return false;
			}
			if (description.Length == 0) {
				this.labelError.Text = "No Description";
				this.labelError.Visible = true;
				return false;
			}

			this.labelError.Visible = false;

			this.taskList.AddTask(project, description, duration);
			this.populateProjects();
			return true;
		}

		private void startTask() {
			if (this.taskList.CurrentTask == null)
				throw new Exception("No task to start");
			this.taskList.StartCurrent();
			this.haveCurrentTask = true;
			this.labelDuration.Text = "00:00:00";
			this.timer.Start();
			this.setButtonEnabled();
		}

		private void stopTask() {
			this.taskList.FinishCurrent();
			this.timer.Stop();
			this.haveCurrentTask = false;
			this.setButtonEnabled();
			this.fileHandler.SaveTasks(this.taskList.Serialize());
		}

		private void pauseTask() {
			this.taskList.PauseCurrent();
			this.timer.Stop();
			this.setButtonEnabled();
		}

		private void resumeTask() {
			this.taskList.ResumeCurrnt();
			this.timer.Start();
			this.setButtonEnabled();
		}

		private void timer_Tick(object sender, EventArgs e) {
			if (!this.haveCurrentTask) {
				this.timer.Stop();
				return;
			}
			this.labelDuration.Text = this.taskList.CurrentTask.Duration.ToString("hh':'mm':'ss");
			this.labelDurationTotal.Text = this.taskList.CurrentProjectTime.ToString("hh':'mm':'ss");
		}

		private void buttonStartStop_Click(object sender, EventArgs e) {
			if (!this.haveCurrentTask) {
				if (!this.createTask())
					return;
			}
			switch (this.taskList.CurrentState) {
				case Task.States.NEW:
					this.startTask();
					break;
				case Task.States.IN_PROGRESS:
				case Task.States.PAUSED:
					this.stopTask();
					break;
			}
		}

		private void buttonPause_Click(object sender, EventArgs e) {
			if (!this.haveCurrentTask)
				return;
			switch (this.taskList.CurrentState) {
				case Task.States.IN_PROGRESS:
					this.pauseTask();
					break;
				case Task.States.PAUSED:
					this.resumeTask();
					break;
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			// Update the list of projects
			if ((sender as TabControl).SelectedIndex != 1)
				return;
			this.comboBoxProjectList.Items.Clear();
			foreach (string project in this.taskList.Projects) {
				this.comboBoxProjectList.Items.Add(project);
			}
			if (this.taskList.Projects.Count > 0)
				this.comboBoxProjectList.Text = this.taskList.Projects[0];
		}

		private void comboBoxProject_TextChanged(object sender, EventArgs e) {
			string project = (sender as ComboBox).Text;
			this.labelDurationTotal.Text = this.taskList.GetProjectTime(project).ToString("hh':'mm':'ss");
		}
    }
}
