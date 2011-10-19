namespace timer {
	partial class TaskEdit {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.comboBoxProject = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.listBoxWorkTimes = new System.Windows.Forms.ListBox();
			this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
			this.buttonDeleteWorkTime = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxProject
			// 
			this.comboBoxProject.FormattingEnabled = true;
			this.comboBoxProject.Location = new System.Drawing.Point(63, 6);
			this.comboBoxProject.Name = "comboBoxProject";
			this.comboBoxProject.Size = new System.Drawing.Size(179, 21);
			this.comboBoxProject.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Project:";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDescription.Location = new System.Drawing.Point(12, 46);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(259, 58);
			this.textBoxDescription.TabIndex = 3;
			this.textBoxDescription.Text = "The task at hand";
			// 
			// listBoxWorkTimes
			// 
			this.listBoxWorkTimes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxWorkTimes.FormattingEnabled = true;
			this.listBoxWorkTimes.Location = new System.Drawing.Point(12, 111);
			this.listBoxWorkTimes.Name = "listBoxWorkTimes";
			this.listBoxWorkTimes.Size = new System.Drawing.Size(259, 82);
			this.listBoxWorkTimes.TabIndex = 4;
			this.listBoxWorkTimes.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkTimes_SelectedIndexChanged);
			// 
			// dateTimePickerFrom
			// 
			this.dateTimePickerFrom.CustomFormat = "dd/mm/yyyy hh:mm:ss tt";
			this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerFrom.Location = new System.Drawing.Point(78, 200);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(176, 20);
			this.dateTimePickerFrom.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 203);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "From:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 230);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Duration:";
			// 
			// dateTimePickerDuration
			// 
			this.dateTimePickerDuration.CustomFormat = "HH:mm:ss";
			this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDuration.Location = new System.Drawing.Point(78, 226);
			this.dateTimePickerDuration.Name = "dateTimePickerDuration";
			this.dateTimePickerDuration.ShowUpDown = true;
			this.dateTimePickerDuration.Size = new System.Drawing.Size(75, 20);
			this.dateTimePickerDuration.TabIndex = 7;
			this.dateTimePickerDuration.Value = new System.DateTime(2011, 10, 19, 0, 0, 0, 0);
			// 
			// buttonDeleteWorkTime
			// 
			this.buttonDeleteWorkTime.Location = new System.Drawing.Point(88, 252);
			this.buttonDeleteWorkTime.Name = "buttonDeleteWorkTime";
			this.buttonDeleteWorkTime.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteWorkTime.TabIndex = 8;
			this.buttonDeleteWorkTime.Text = "Delete";
			this.buttonDeleteWorkTime.UseVisualStyleBackColor = true;
			this.buttonDeleteWorkTime.Click += new System.EventHandler(this.buttonDeleteWorkTime_Click);
			// 
			// TaskEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(283, 285);
			this.Controls.Add(this.buttonDeleteWorkTime);
			this.Controls.Add(this.dateTimePickerDuration);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePickerFrom);
			this.Controls.Add(this.listBoxWorkTimes);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxProject);
			this.Name = "TaskEdit";
			this.Text = "Edit a Task";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxProject;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.ListBox listBoxWorkTimes;
		private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
		private System.Windows.Forms.Button buttonDeleteWorkTime;
	}
}