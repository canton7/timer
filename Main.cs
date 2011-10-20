using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace timer {
	public partial class Main : Form {
		private TaskList taskList;

		private bool haveCurrentTask = false;

		private FileHandler fileHandler;

		private List<Task> listBoxTasksContents = new List<Task>();

		private bool alarmSounding = false;
		private SoundPlayer alarm;

		public Main() {
			InitializeComponent();
			this.fileHandler = FileHandler.Instance;

			this.taskList = new TaskList(this.fileHandler.LoadTasks());
			this.populateProjects();

			this.alarm = new SoundPlayer("../../alarm.wav");
        }

		private void setButtonEnabled() {
			if (!this.haveCurrentTask) {
				this.buttonStartStop.Text = "Start";
				this.progressBar.Style = ProgressBarStyle.Blocks;
				return;
			}

			switch (this.taskList.CurrentState) {
				case Task.States.STOPPED:
					this.buttonStartStop.Text = "Start";
					this.progressBar.Style = ProgressBarStyle.Blocks;
					break;
				case Task.States.IN_PROGRESS:
					this.buttonStartStop.Text = "Stop";
					this.progressBar.Style = ProgressBarStyle.Marquee;
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
			TimeSpan duration = new TimeSpan(this.dateTimePickerDuration.Value.Hour, this.dateTimePickerDuration.Value.Minute, this.dateTimePickerDuration.Value.Second);

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

			// Assume they just want to continue the current task, if they didn't change it
			if (this.taskList.HaveTasks && project == this.taskList.CurrentTask.Project && description == this.taskList.CurrentTask.Description && 
					duration == this.taskList.CurrentTask.ExpectedTime)
				return true;

			this.taskList.AddTask(project, description, duration);
			this.populateProjects();
			return true;
		}

		private void startTask() {
			if (this.taskList.CurrentTask == null)
				throw new Exception("No task to start");
			this.taskList.StartCurrent();
			this.haveCurrentTask = true;
			this.labelDuration.Text = this.taskList.CurrentTask.Duration.ToString("hh':'mm':'ss");
			this.timer.Start();
			this.setButtonEnabled();
		}

		private void stopTask() {
			this.taskList.StopCurrent();
			this.timer.Stop();
			this.haveCurrentTask = false;
			this.setButtonEnabled();
			this.fileHandler.SaveTasks(this.taskList.Serialize());
		}

		private void populateTaskInfo() {
			this.textBoxDescription.Text = this.taskList.CurrentTask.Description;
			this.dateTimePickerDuration.Value = new DateTime(1970, 1, 1, 0, 0, 0) + this.taskList.CurrentTask.ExpectedTime;
		}

		private void populateTaskList() {
			string project = this.comboBoxProjectTasks.Text;

			this.listBoxTasks.Items.Clear();
			this.listBoxTasksContents.Clear();

			string item;
			foreach (Task task in this.taskList.GetProjectTasks(project)) {
				if (task.ExpectedTime.Ticks == 0)
					item = String.Format("{0} - {1}", task.Duration.ToString("hh':'mm':'ss"), task.Description);
				else
					item = String.Format("{0}/{1} - {2}", task.Duration.ToString("hh':'mm':'ss"), task.ExpectedTime.ToString("hh':'mm"), task.Description);

				this.listBoxTasks.Items.Add(item);
				// keep record for later
				this.listBoxTasksContents.Add(task);
			}
		}

		private void populateProjectTasks() {
			// Update the list of projects
			this.comboBoxProjectTasks.Items.Clear();
			foreach (string project in this.taskList.Projects) {
				this.comboBoxProjectTasks.Items.Add(project);
			}
			if (this.taskList.Projects.Count > 0)
				this.comboBoxProjectTasks.Text = (this.comboBoxProjectTasks.Items.Contains(this.comboBoxProject.Text)) ? this.comboBoxProject.Text : this.taskList.Projects[0];
		}

		private void continueTask(Task task) {
			this.stopTask();
			this.taskList.SetCurrentTask(task);
			// order of projects will have changed
			this.populateProjects();
			this.populateTaskInfo();
			this.startTask();
		}

		private void deleteTask(Task task) {
			if (MessageBox.Show("Do you really want to delete this task?", "Really delete task?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
				return;
			// Stop the task if it's the current one
			bool currentTask = this.taskList.CurrentTask == task;
			if (currentTask)
				this.stopTask();
			this.taskList.DeleteTask(task);
			// If it was the current task, re-populate
			this.populateProjects();
			this.populateProjectTasks();
			this.populateTaskInfo();
			this.populateTaskList();
			this.fileHandler.SaveTasks(this.taskList.Serialize());
		}

		private void editTask(int task_index, Task task) {
			this.stopTask();
			// Copy the task so they don't edit the original copy
			Task taskNew = new Task(task.Serialize());
			using (TaskEdit taskEdit = new TaskEdit(this.taskList, taskNew)) {
				DialogResult result = taskEdit.ShowDialog();
				if (result != DialogResult.OK)
					return;
				this.taskList.ReplaceTask(task_index, taskEdit.Task);

				this.populateProjects();
				this.populateProjectTasks();
				this.comboBoxProjectTasks.SelectedValue = taskEdit.Task.Project;
			}
			this.fileHandler.SaveTasks(this.taskList.Serialize());
		}

		private void startAlarm() {
			this.alarm.PlayLooping();
			// Start the alarm timer
			this.taskList.CurrentTask.SoundedAlarm = true;
			this.timerAlarm.Start();
			this.alarmSounding = true;
		}

		private void stopAlarm() {
			this.alarm.Stop();
			this.timerAlarm.Stop();
			this.alarmSounding = false;
			this.buttonStartStop.BackColor = Color.Transparent;
		}

		private void timer_Tick(object sender, EventArgs e) {
			if (!this.haveCurrentTask) {
				this.timer.Stop();
				return;
			}
			this.labelDuration.Text = this.taskList.CurrentTask.Duration.ToString("hh':'mm':'ss");
			this.labelDurationTotal.Text = this.taskList.CurrentProjectTime.ToString("hh':'mm':'ss");

			if (this.taskList.CurrentTask.Duration > this.taskList.CurrentTask.ExpectedTime && !this.alarmSounding && !this.taskList.CurrentTask.SoundedAlarm)
				this.startAlarm();
		}

		private void timerAlarm_Tick(object sender, EventArgs e) {
			if (this.buttonStartStop.BackColor != Color.Red)
				this.buttonStartStop.BackColor = Color.Red;
			else
				this.buttonStartStop.BackColor = Color.Transparent;
		}

		private void buttonStartStop_Click(object sender, EventArgs e) {
			if (this.alarmSounding)
				this.stopAlarm();

			if (!this.haveCurrentTask) {
				if (!this.createTask())
					return;
			}
			switch (this.taskList.CurrentState) {
				case Task.States.STOPPED:
					this.startTask();
					break;
				case Task.States.IN_PROGRESS:
					this.stopTask();
					break;
			}
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			this.createTask();
			// Set fields to what they were before, if any
			if (this.taskList.HaveTasks) {
				this.comboBoxProject.Text = this.taskList.CurrentProject;
				this.textBoxDescription.Text = this.taskList.CurrentTask.Description;
			}
		}

		private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
			if ((sender as TabControl).SelectedIndex != 1)
				return;
			this.populateProjectTasks();
		}

		private void comboBoxProject_TextChanged(object sender, EventArgs e) {
			ComboBox senderbox = sender as ComboBox;
			this.labelDurationTotal.Text = this.taskList.GetProjectTime(senderbox.Text).ToString("hh':'mm':'ss");
			if (this.taskList.HaveTasks)
				this.labelDuration.Text = this.taskList.CurrentTask.Duration.ToString("hh':'mm':'ss");
		}

		private void comboBoxProjectTasks_SelectedIndexChanged(object sender, EventArgs e) {
			ComboBox senderbox = sender as ComboBox;
			this.populateTaskList();
		}

		private void Main_FormClosing(object sender, FormClosingEventArgs e) {
			// Also causes the current task to save
			this.stopTask();
		}

		private void buttonContinueTask_Click(object sender, EventArgs e) {;
			int index = this.listBoxTasks.SelectedIndex;
			if (index == -1)
				return;
			this.continueTask(this.listBoxTasksContents[index]);
			this.tabControl1.SelectedIndex = 0;
		}
		private void listBoxTasks_MouseDoubleClick(object sender, MouseEventArgs e) {
			int index = this.listBoxTasks.SelectedIndex;
			if (index == -1)
				return;
			this.continueTask(this.listBoxTasksContents[index]);
			this.tabControl1.SelectedIndex = 0;
		}

		private void buttonEditTask_Click(object sender, EventArgs e) {
			int index = this.listBoxTasks.SelectedIndex;
			if (index == -1)
				return;
			this.editTask(index, this.listBoxTasksContents[index]);
		}

		private void buttonDeleteTask_Click(object sender, EventArgs e) {
			int index = this.listBoxTasks.SelectedIndex;
			if (index == -1)
				return;
			this.deleteTask(this.listBoxTasksContents[index]);
		}
    }
}
