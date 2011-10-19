namespace timer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageTime = new System.Windows.Forms.TabPage();
			this.labelDurationTotal = new System.Windows.Forms.Label();
			this.labelError = new System.Windows.Forms.Label();
			this.labelDuration = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerDuration = new System.Windows.Forms.DateTimePicker();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonStartStop = new System.Windows.Forms.Button();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.comboBoxProject = new System.Windows.Forms.ComboBox();
			this.tabPageTasks = new System.Windows.Forms.TabPage();
			this.labelDurationTotalTasks = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxProjectTasks = new System.Windows.Forms.ComboBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.listBoxTasks = new System.Windows.Forms.ListBox();
			this.tabControl1.SuspendLayout();
			this.tabPageTime.SuspendLayout();
			this.tabPageTasks.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageTime);
			this.tabControl1.Controls.Add(this.tabPageTasks);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(264, 252);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPageTime
			// 
			this.tabPageTime.Controls.Add(this.labelDurationTotal);
			this.tabPageTime.Controls.Add(this.labelError);
			this.tabPageTime.Controls.Add(this.labelDuration);
			this.tabPageTime.Controls.Add(this.label1);
			this.tabPageTime.Controls.Add(this.dateTimePickerDuration);
			this.tabPageTime.Controls.Add(this.buttonSave);
			this.tabPageTime.Controls.Add(this.buttonStartStop);
			this.tabPageTime.Controls.Add(this.textBoxDescription);
			this.tabPageTime.Controls.Add(this.comboBoxProject);
			this.tabPageTime.Location = new System.Drawing.Point(4, 22);
			this.tabPageTime.Name = "tabPageTime";
			this.tabPageTime.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTime.Size = new System.Drawing.Size(256, 226);
			this.tabPageTime.TabIndex = 0;
			this.tabPageTime.Text = "Time";
			this.tabPageTime.UseVisualStyleBackColor = true;
			// 
			// labelDurationTotal
			// 
			this.labelDurationTotal.AutoSize = true;
			this.labelDurationTotal.Location = new System.Drawing.Point(130, 143);
			this.labelDurationTotal.Name = "labelDurationTotal";
			this.labelDurationTotal.Size = new System.Drawing.Size(49, 13);
			this.labelDurationTotal.TabIndex = 11;
			this.labelDurationTotal.Text = "00:00:00";
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(8, 175);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(34, 13);
			this.labelError.TabIndex = 10;
			this.labelError.Text = "Errors";
			this.labelError.Visible = false;
			// 
			// labelDuration
			// 
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(12, 143);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(49, 13);
			this.labelDuration.TabIndex = 8;
			this.labelDuration.Text = "00:00:00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Duration";
			// 
			// dateTimePickerDuration
			// 
			this.dateTimePickerDuration.CustomFormat = "HH:mm";
			this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDuration.Location = new System.Drawing.Point(62, 106);
			this.dateTimePickerDuration.Name = "dateTimePickerDuration";
			this.dateTimePickerDuration.ShowUpDown = true;
			this.dateTimePickerDuration.Size = new System.Drawing.Size(75, 20);
			this.dateTimePickerDuration.TabIndex = 6;
			this.dateTimePickerDuration.Value = new System.DateTime(2011, 10, 19, 0, 0, 0, 0);
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(172, 106);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonStartStop
			// 
			this.buttonStartStop.Location = new System.Drawing.Point(8, 194);
			this.buttonStartStop.Name = "buttonStartStop";
			this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStartStop.TabIndex = 2;
			this.buttonStartStop.Text = "Start";
			this.buttonStartStop.UseVisualStyleBackColor = true;
			this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(8, 33);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(239, 67);
			this.textBoxDescription.TabIndex = 1;
			this.textBoxDescription.Text = "The task at hand";
			// 
			// comboBoxProject
			// 
			this.comboBoxProject.FormattingEnabled = true;
			this.comboBoxProject.Location = new System.Drawing.Point(8, 6);
			this.comboBoxProject.Name = "comboBoxProject";
			this.comboBoxProject.Size = new System.Drawing.Size(239, 21);
			this.comboBoxProject.TabIndex = 0;
			this.comboBoxProject.TextChanged += new System.EventHandler(this.comboBoxProject_TextChanged);
			// 
			// tabPageTasks
			// 
			this.tabPageTasks.Controls.Add(this.listBoxTasks);
			this.tabPageTasks.Controls.Add(this.labelDurationTotalTasks);
			this.tabPageTasks.Controls.Add(this.label3);
			this.tabPageTasks.Controls.Add(this.label2);
			this.tabPageTasks.Controls.Add(this.comboBoxProjectTasks);
			this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
			this.tabPageTasks.Name = "tabPageTasks";
			this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTasks.Size = new System.Drawing.Size(256, 226);
			this.tabPageTasks.TabIndex = 1;
			this.tabPageTasks.Text = "Tasks";
			this.tabPageTasks.UseVisualStyleBackColor = true;
			// 
			// labelDurationTotalTasks
			// 
			this.labelDurationTotalTasks.AutoSize = true;
			this.labelDurationTotalTasks.Location = new System.Drawing.Point(50, 38);
			this.labelDurationTotalTasks.Name = "labelDurationTotalTasks";
			this.labelDurationTotalTasks.Size = new System.Drawing.Size(49, 13);
			this.labelDurationTotalTasks.TabIndex = 3;
			this.labelDurationTotalTasks.Text = "00:00:00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Project:";
			// 
			// comboBoxProjectTasks
			// 
			this.comboBoxProjectTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxProjectTasks.FormattingEnabled = true;
			this.comboBoxProjectTasks.Location = new System.Drawing.Point(52, 6);
			this.comboBoxProjectTasks.Name = "comboBoxProjectTasks";
			this.comboBoxProjectTasks.Size = new System.Drawing.Size(121, 21);
			this.comboBoxProjectTasks.TabIndex = 0;
			this.comboBoxProjectTasks.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjectTasks_SelectedIndexChanged);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// listBoxTasks
			// 
			this.listBoxTasks.FormattingEnabled = true;
			this.listBoxTasks.Location = new System.Drawing.Point(3, 67);
			this.listBoxTasks.Name = "listBoxTasks";
			this.listBoxTasks.Size = new System.Drawing.Size(250, 160);
			this.listBoxTasks.TabIndex = 4;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(263, 251);
			this.Controls.Add(this.tabControl1);
			this.Name = "Main";
			this.Text = "Timer";
			this.tabControl1.ResumeLayout(false);
			this.tabPageTime.ResumeLayout(false);
			this.tabPageTime.PerformLayout();
			this.tabPageTasks.ResumeLayout(false);
			this.tabPageTasks.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTime;
		private System.Windows.Forms.TabPage tabPageTasks;
		private System.Windows.Forms.Button buttonStartStop;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.DateTimePicker dateTimePickerDuration;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelDuration;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBoxProjectTasks;
		private System.Windows.Forms.Label labelError;
		private System.Windows.Forms.ComboBox comboBoxProject;
		private System.Windows.Forms.Label labelDurationTotal;
		private System.Windows.Forms.Label labelDurationTotalTasks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listBoxTasks;
    }
}

