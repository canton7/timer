using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace timer {
	public partial class TaskEdit : Form {
		private TaskList taskList;

		private Task task;
		public Task Task {
			get { return this.task; }
		}

		public TaskEdit(TaskList taskList, Task task) {
			this.taskList = taskList;
			this.task = task;

			InitializeComponent();

			this.populateFields();
		}

		private void populateFields() {
			this.comboBoxProject.Text = this.task.Project;
			this.comboBoxProject.Items.Clear();
			foreach (string project in this.taskList.Projects) {
				this.comboBoxProject.Items.Add(project);
			}

			this.dateTimePickerExpectedDuration.Value = new DateTime(1970, 1, 1, 0, 0, 0) + this.task.ExpectedTime;
			this.textBoxDescription.Text = this.task.Description;

			this.listBoxWorkTimes.Items.Clear();
			foreach (Task.WorkTime workTime in this.task.WorkTimes) {
				this.listBoxWorkTimes.Items.Add(String.Format("{0} for {1}", workTime.StartedAt, workTime.StoppedAt - workTime.StartedAt));
			}

			this.labelTotalDuration.Text = this.task.Duration.ToString("hh':'mm':'ss");
		}

		private void populateFromDuration(Task.WorkTime workTime) {
			this.dateTimePickerFrom.Value = workTime.StartedAt;
			this.dateTimePickerDuration.Value = new DateTime(1970, 1, 1, 0, 0, 0) + (workTime.StoppedAt.Value - workTime.StartedAt);
		}

		private void deleteWorkTime(Task.WorkTime workTime) {
			this.task.DeleteWorkTime(workTime);
			this.populateFields();
		}

		private void editWorkTime(Task.WorkTime workTime) {
			workTime.StartedAt = this.dateTimePickerFrom.Value;
			workTime.StoppedAt = this.dateTimePickerFrom.Value + (this.dateTimePickerDuration.Value - new DateTime(1970, 1, 1, 0, 0, 0));
			this.task.SortWorkTimes();
			this.populateFields();
			// Find the moved task, and select
			int index = this.task.WorkTimes.FindIndex(x => x.StartedAt == workTime.StartedAt && x.StoppedAt == workTime.StoppedAt);
			this.listBoxWorkTimes.SelectedIndex = index;
			this.task.EditWorkTime();
			this.labelTotalDuration.Text = this.task.Duration.ToString("hh':'mm':'ss");
		}

		private void addWorkTime() {
			Task.WorkTime workTime = new Task.WorkTime();
			workTime.StartedAt = this.dateTimePickerFrom.Value;
			workTime.StoppedAt = this.dateTimePickerFrom.Value + (this.dateTimePickerDuration.Value - new DateTime(1970, 1, 1, 0, 0, 0));
			this.task.AddWorkTime(workTime);
			this.populateFields();
			// Find the new task, and select
			int index = this.task.WorkTimes.FindIndex(x => x.StartedAt == workTime.StartedAt && x.StoppedAt == workTime.StoppedAt);
			this.listBoxWorkTimes.SelectedIndex = index;
			this.labelTotalDuration.Text = this.task.Duration.ToString("hh':'mm':'ss");
		}

		private void listBoxWorkTimes_SelectedIndexChanged(object sender, EventArgs e) {
			int index = (sender as ListBox).SelectedIndex;
			if (index == -1)
				return;
			this.populateFromDuration(this.task.WorkTimes[index]);
		}

		private void buttonDeleteWorkTime_Click(object sender, EventArgs e) {
			int index = this.listBoxWorkTimes.SelectedIndex;
			if (index == -1)
				return;
			this.deleteWorkTime(this.task.WorkTimes[index]);
			this.listBoxWorkTimes.SelectedIndex = index;
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			if (this.listBoxWorkTimes.SelectedIndex == -1)
				return;
			this.editWorkTime(this.task.WorkTimes[this.listBoxWorkTimes.SelectedIndex]);
		}

		private void buttonNew_Click(object sender, EventArgs e) {
			this.addWorkTime();
		}

		private void buttonSave_Click(object sender, EventArgs e) {
			this.task.Project = this.comboBoxProject.Text;
			this.task.Description = this.textBoxDescription.Text;
			this.task.ExpectedTime = this.dateTimePickerExpectedDuration.Value - new DateTime(1970, 1, 1, 0, 0, 0);
		}

		private void buttonNow_Click(object sender, EventArgs e) {
			this.dateTimePickerFrom.Value = DateTime.Now;
		}
	}
}
