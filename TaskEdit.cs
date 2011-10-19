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

			this.textBoxDescription.Text = this.task.Description;

			this.listBoxWorkTimes.Items.Clear();
			foreach (Task.WorkTime workTime in this.task.WorkTimes) {
				this.listBoxWorkTimes.Items.Add(String.Format("{0} for {1}", workTime.StartedAt, workTime.StoppedAt - workTime.StartedAt));
			}
		}

		private void populateFromDuration(Task.WorkTime workTime) {
			this.dateTimePickerFrom.Value = workTime.StartedAt;
			this.dateTimePickerDuration.Value = new DateTime(1970, 1, 1, 0, 0, 0) + (workTime.StoppedAt.Value - workTime.StartedAt);
		}

		private void deleteWorkTime(Task.WorkTime workTime) {
			this.task.DeleteWorkTime(workTime);
			this.populateFields();
		}

		private void listBoxWorkTimes_SelectedIndexChanged(object sender, EventArgs e) {
			int index = (sender as ListBox).SelectedIndex;
			this.populateFromDuration(this.task.WorkTimes[index]);
		}

		private void buttonDeleteWorkTime_Click(object sender, EventArgs e) {
			this.deleteWorkTime(this.task.WorkTimes[this.listBoxWorkTimes.SelectedIndex]);
		}
	}
}
