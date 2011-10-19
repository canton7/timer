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
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonNew = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
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
			this.textBoxDescription.Size = new System.Drawing.Size(253, 58);
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
			this.listBoxWorkTimes.Size = new System.Drawing.Size(253, 95);
			this.listBoxWorkTimes.TabIndex = 4;
			this.listBoxWorkTimes.SelectedIndexChanged += new System.EventHandler(this.listBoxWorkTimes_SelectedIndexChanged);
			// 
			// dateTimePickerFrom
			// 
			this.dateTimePickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dateTimePickerFrom.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
			this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerFrom.Location = new System.Drawing.Point(80, 213);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(176, 20);
			this.dateTimePickerFrom.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "From:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 243);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Duration:";
			// 
			// dateTimePickerDuration
			// 
			this.dateTimePickerDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dateTimePickerDuration.CustomFormat = "HH:mm:ss";
			this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDuration.Location = new System.Drawing.Point(78, 239);
			this.dateTimePickerDuration.Name = "dateTimePickerDuration";
			this.dateTimePickerDuration.ShowUpDown = true;
			this.dateTimePickerDuration.Size = new System.Drawing.Size(75, 20);
			this.dateTimePickerDuration.TabIndex = 7;
			this.dateTimePickerDuration.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			// 
			// buttonDeleteWorkTime
			// 
			this.buttonDeleteWorkTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDeleteWorkTime.Location = new System.Drawing.Point(196, 272);
			this.buttonDeleteWorkTime.Name = "buttonDeleteWorkTime";
			this.buttonDeleteWorkTime.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteWorkTime.TabIndex = 8;
			this.buttonDeleteWorkTime.Text = "Delete";
			this.buttonDeleteWorkTime.UseVisualStyleBackColor = true;
			this.buttonDeleteWorkTime.Click += new System.EventHandler(this.buttonDeleteWorkTime_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonEdit.Location = new System.Drawing.Point(7, 272);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(75, 23);
			this.buttonEdit.TabIndex = 8;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = true;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonNew
			// 
			this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonNew.Location = new System.Drawing.Point(101, 272);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(75, 23);
			this.buttonNew.TabIndex = 9;
			this.buttonNew.Text = "New";
			this.buttonNew.UseVisualStyleBackColor = true;
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSave.Location = new System.Drawing.Point(51, 316);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 28);
			this.buttonSave.TabIndex = 10;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(146, 316);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 28);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// TaskEdit
			// 
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(277, 351);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonNew);
			this.Controls.Add(this.buttonEdit);
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
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonNew;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
	}
}