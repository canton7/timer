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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			this.buttonDeleteTask = new System.Windows.Forms.Button();
			this.listBoxTasks = new System.Windows.Forms.ListBox();
			this.buttonEditTask = new System.Windows.Forms.Button();
			this.labelDurationTotalTasks = new System.Windows.Forms.Label();
			this.buttonContinueTask = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBoxProjectTasks = new System.Windows.Forms.ComboBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
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
			this.tabControl1.Size = new System.Drawing.Size(237, 234);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPageTime
			// 
			this.tabPageTime.Controls.Add(this.label5);
			this.tabPageTime.Controls.Add(this.label4);
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
			this.tabPageTime.Size = new System.Drawing.Size(229, 208);
			this.tabPageTime.TabIndex = 0;
			this.tabPageTime.Text = "Time";
			this.tabPageTime.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 182);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 20);
			this.label5.TabIndex = 13;
			this.label5.Text = "Total:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Project:";
			// 
			// labelDurationTotal
			// 
			this.labelDurationTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelDurationTotal.AutoSize = true;
			this.labelDurationTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDurationTotal.Location = new System.Drawing.Point(60, 182);
			this.labelDurationTotal.Name = "labelDurationTotal";
			this.labelDurationTotal.Size = new System.Drawing.Size(71, 20);
			this.labelDurationTotal.TabIndex = 11;
			this.labelDurationTotal.Text = "00:00:00";
			// 
			// labelError
			// 
			this.labelError.AutoSize = true;
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(11, 133);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(34, 13);
			this.labelError.TabIndex = 10;
			this.labelError.Text = "Errors";
			this.labelError.Visible = false;
			// 
			// labelDuration
			// 
			this.labelDuration.AutoSize = true;
			this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDuration.Location = new System.Drawing.Point(10, 146);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(127, 33);
			this.labelDuration.TabIndex = 8;
			this.labelDuration.Text = "00:00:00";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 109);
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
			this.dateTimePickerDuration.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(145, 106);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(75, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonStartStop
			// 
			this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStartStop.Location = new System.Drawing.Point(145, 146);
			this.buttonStartStop.Name = "buttonStartStop";
			this.buttonStartStop.Size = new System.Drawing.Size(75, 56);
			this.buttonStartStop.TabIndex = 2;
			this.buttonStartStop.Text = "Start";
			this.buttonStartStop.UseVisualStyleBackColor = true;
			this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDescription.Location = new System.Drawing.Point(8, 33);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(212, 67);
			this.textBoxDescription.TabIndex = 1;
			this.textBoxDescription.Text = "The task at hand";
			// 
			// comboBoxProject
			// 
			this.comboBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxProject.FormattingEnabled = true;
			this.comboBoxProject.Location = new System.Drawing.Point(57, 6);
			this.comboBoxProject.Name = "comboBoxProject";
			this.comboBoxProject.Size = new System.Drawing.Size(163, 21);
			this.comboBoxProject.TabIndex = 0;
			this.comboBoxProject.TextChanged += new System.EventHandler(this.comboBoxProject_TextChanged);
			// 
			// tabPageTasks
			// 
			this.tabPageTasks.Controls.Add(this.buttonDeleteTask);
			this.tabPageTasks.Controls.Add(this.listBoxTasks);
			this.tabPageTasks.Controls.Add(this.buttonEditTask);
			this.tabPageTasks.Controls.Add(this.labelDurationTotalTasks);
			this.tabPageTasks.Controls.Add(this.buttonContinueTask);
			this.tabPageTasks.Controls.Add(this.label3);
			this.tabPageTasks.Controls.Add(this.label2);
			this.tabPageTasks.Controls.Add(this.comboBoxProjectTasks);
			this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
			this.tabPageTasks.Name = "tabPageTasks";
			this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTasks.Size = new System.Drawing.Size(229, 208);
			this.tabPageTasks.TabIndex = 1;
			this.tabPageTasks.Text = "Tasks";
			this.tabPageTasks.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteTask
			// 
			this.buttonDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDeleteTask.Location = new System.Drawing.Point(148, 179);
			this.buttonDeleteTask.Name = "buttonDeleteTask";
			this.buttonDeleteTask.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteTask.TabIndex = 1;
			this.buttonDeleteTask.Text = "Delete";
			this.buttonDeleteTask.UseVisualStyleBackColor = true;
			this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
			// 
			// listBoxTasks
			// 
			this.listBoxTasks.FormattingEnabled = true;
			this.listBoxTasks.Location = new System.Drawing.Point(3, 67);
			this.listBoxTasks.Name = "listBoxTasks";
			this.listBoxTasks.Size = new System.Drawing.Size(223, 95);
			this.listBoxTasks.TabIndex = 4;
			// 
			// buttonEditTask
			// 
			this.buttonEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonEditTask.Location = new System.Drawing.Point(83, 179);
			this.buttonEditTask.Name = "buttonEditTask";
			this.buttonEditTask.Size = new System.Drawing.Size(59, 23);
			this.buttonEditTask.TabIndex = 1;
			this.buttonEditTask.Text = "Edit";
			this.buttonEditTask.UseVisualStyleBackColor = true;
			this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
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
			// buttonContinueTask
			// 
			this.buttonContinueTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonContinueTask.Location = new System.Drawing.Point(6, 179);
			this.buttonContinueTask.Name = "buttonContinueTask";
			this.buttonContinueTask.Size = new System.Drawing.Size(71, 23);
			this.buttonContinueTask.TabIndex = 1;
			this.buttonContinueTask.Text = "Continue";
			this.buttonContinueTask.UseVisualStyleBackColor = true;
			this.buttonContinueTask.Click += new System.EventHandler(this.buttonContinueTask_Click);
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
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(236, 235);
			this.Controls.Add(this.tabControl1);
			this.Name = "Main";
			this.Text = "Timer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
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
		private System.Windows.Forms.Button buttonContinueTask;
		private System.Windows.Forms.Button buttonEditTask;
		private System.Windows.Forms.Button buttonDeleteTask;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
    }
}

