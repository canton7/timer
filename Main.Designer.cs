﻿namespace timer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.checkBoxOnTop = new System.Windows.Forms.CheckBox();
			this.checkBoxAlarm = new System.Windows.Forms.CheckBox();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.timerAlarm = new System.Windows.Forms.Timer(this.components);
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showHideToolStripMenuItemShowHide = new System.Windows.Forms.ToolStripMenuItem();
			this.startStopToolStripMenuItemStartStop = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
			this.timerClick = new System.Windows.Forms.Timer(this.components);
			this.checkBoxIcon = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPageTime.SuspendLayout();
			this.tabPageTasks.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.contextMenuStripNotify.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageTime);
			this.tabControl1.Controls.Add(this.tabPageTasks);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(225, 213);
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
			this.tabPageTime.Size = new System.Drawing.Size(217, 187);
			this.tabPageTime.TabIndex = 0;
			this.tabPageTime.Text = "Time";
			this.tabPageTime.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 160);
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
			this.labelDurationTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDurationTotal.AutoSize = true;
			this.labelDurationTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDurationTotal.Location = new System.Drawing.Point(56, 160);
			this.labelDurationTotal.Name = "labelDurationTotal";
			this.labelDurationTotal.Size = new System.Drawing.Size(71, 20);
			this.labelDurationTotal.TabIndex = 11;
			this.labelDurationTotal.Text = "00:00:00";
			// 
			// labelError
			// 
			this.labelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelError.AutoSize = true;
			this.labelError.ForeColor = System.Drawing.Color.Red;
			this.labelError.Location = new System.Drawing.Point(13, 111);
			this.labelError.Name = "labelError";
			this.labelError.Size = new System.Drawing.Size(34, 13);
			this.labelError.TabIndex = 10;
			this.labelError.Text = "Errors";
			this.labelError.Visible = false;
			// 
			// labelDuration
			// 
			this.labelDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelDuration.AutoSize = true;
			this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDuration.Location = new System.Drawing.Point(6, 124);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(127, 33);
			this.labelDuration.TabIndex = 8;
			this.labelDuration.Text = "00:00:00";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Duration:";
			// 
			// dateTimePickerDuration
			// 
			this.dateTimePickerDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dateTimePickerDuration.CustomFormat = "HH:mm:ss";
			this.dateTimePickerDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDuration.Location = new System.Drawing.Point(62, 84);
			this.dateTimePickerDuration.Name = "dateTimePickerDuration";
			this.dateTimePickerDuration.ShowUpDown = true;
			this.dateTimePickerDuration.Size = new System.Drawing.Size(69, 20);
			this.dateTimePickerDuration.TabIndex = 6;
			this.dateTimePickerDuration.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSave.Location = new System.Drawing.Point(137, 84);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(71, 23);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonStartStop
			// 
			this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStartStop.Location = new System.Drawing.Point(137, 124);
			this.buttonStartStop.Name = "buttonStartStop";
			this.buttonStartStop.Size = new System.Drawing.Size(71, 56);
			this.buttonStartStop.TabIndex = 2;
			this.buttonStartStop.Text = "Start";
			this.buttonStartStop.UseVisualStyleBackColor = false;
			this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDescription.Location = new System.Drawing.Point(8, 33);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(200, 45);
			this.textBoxDescription.TabIndex = 1;
			this.textBoxDescription.Text = "Task Description";
			// 
			// comboBoxProject
			// 
			this.comboBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxProject.FormattingEnabled = true;
			this.comboBoxProject.Location = new System.Drawing.Point(57, 6);
			this.comboBoxProject.Name = "comboBoxProject";
			this.comboBoxProject.Size = new System.Drawing.Size(151, 21);
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
			this.tabPageTasks.Size = new System.Drawing.Size(217, 187);
			this.tabPageTasks.TabIndex = 1;
			this.tabPageTasks.Text = "Tasks";
			this.tabPageTasks.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteTask
			// 
			this.buttonDeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonDeleteTask.Location = new System.Drawing.Point(155, 158);
			this.buttonDeleteTask.Name = "buttonDeleteTask";
			this.buttonDeleteTask.Size = new System.Drawing.Size(58, 23);
			this.buttonDeleteTask.TabIndex = 1;
			this.buttonDeleteTask.Text = "Delete";
			this.buttonDeleteTask.UseVisualStyleBackColor = true;
			this.buttonDeleteTask.Click += new System.EventHandler(this.buttonDeleteTask_Click);
			// 
			// listBoxTasks
			// 
			this.listBoxTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxTasks.FormattingEnabled = true;
			this.listBoxTasks.Location = new System.Drawing.Point(3, 54);
			this.listBoxTasks.Name = "listBoxTasks";
			this.listBoxTasks.Size = new System.Drawing.Size(211, 95);
			this.listBoxTasks.TabIndex = 4;
			this.listBoxTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxTasks_MouseDoubleClick);
			// 
			// buttonEditTask
			// 
			this.buttonEditTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonEditTask.Location = new System.Drawing.Point(79, 158);
			this.buttonEditTask.Name = "buttonEditTask";
			this.buttonEditTask.Size = new System.Drawing.Size(58, 23);
			this.buttonEditTask.TabIndex = 1;
			this.buttonEditTask.Text = "Edit";
			this.buttonEditTask.UseVisualStyleBackColor = true;
			this.buttonEditTask.Click += new System.EventHandler(this.buttonEditTask_Click);
			// 
			// labelDurationTotalTasks
			// 
			this.labelDurationTotalTasks.AutoSize = true;
			this.labelDurationTotalTasks.Location = new System.Drawing.Point(50, 33);
			this.labelDurationTotalTasks.Name = "labelDurationTotalTasks";
			this.labelDurationTotalTasks.Size = new System.Drawing.Size(49, 13);
			this.labelDurationTotalTasks.TabIndex = 3;
			this.labelDurationTotalTasks.Text = "00:00:00";
			// 
			// buttonContinueTask
			// 
			this.buttonContinueTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonContinueTask.Location = new System.Drawing.Point(3, 158);
			this.buttonContinueTask.Name = "buttonContinueTask";
			this.buttonContinueTask.Size = new System.Drawing.Size(58, 23);
			this.buttonContinueTask.TabIndex = 1;
			this.buttonContinueTask.Text = "Continue";
			this.buttonContinueTask.UseVisualStyleBackColor = true;
			this.buttonContinueTask.Click += new System.EventHandler(this.buttonContinueTask_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 33);
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
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.checkBoxIcon);
			this.tabPage1.Controls.Add(this.checkBoxOnTop);
			this.tabPage1.Controls.Add(this.checkBoxAlarm);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(217, 189);
			this.tabPage1.TabIndex = 2;
			this.tabPage1.Text = "Settings";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// checkBoxOnTop
			// 
			this.checkBoxOnTop.AutoSize = true;
			this.checkBoxOnTop.Location = new System.Drawing.Point(9, 43);
			this.checkBoxOnTop.Name = "checkBoxOnTop";
			this.checkBoxOnTop.Size = new System.Drawing.Size(125, 17);
			this.checkBoxOnTop.TabIndex = 1;
			this.checkBoxOnTop.Text = "Show window on top";
			this.checkBoxOnTop.UseVisualStyleBackColor = true;
			this.checkBoxOnTop.CheckedChanged += new System.EventHandler(this.checkBoxOnTop_CheckedChanged);
			// 
			// checkBoxAlarm
			// 
			this.checkBoxAlarm.AutoSize = true;
			this.checkBoxAlarm.Location = new System.Drawing.Point(9, 19);
			this.checkBoxAlarm.Name = "checkBoxAlarm";
			this.checkBoxAlarm.Size = new System.Drawing.Size(174, 17);
			this.checkBoxAlarm.TabIndex = 0;
			this.checkBoxAlarm.Text = "Sound alarm when task time up";
			this.checkBoxAlarm.UseVisualStyleBackColor = true;
			this.checkBoxAlarm.CheckedChanged += new System.EventHandler(this.checkBoxAlarm_CheckedChanged);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// progressBar
			// 
			this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.progressBar.Location = new System.Drawing.Point(3, 214);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(217, 10);
			this.progressBar.TabIndex = 14;
			// 
			// timerAlarm
			// 
			this.timerAlarm.Interval = 250;
			this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotify;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "Testy Text";
			this.notifyIcon.Visible = true;
			this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// contextMenuStripNotify
			// 
			this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItemShowHide,
            this.startStopToolStripMenuItemStartStop,
            this.exitToolStripMenuItemExit});
			this.contextMenuStripNotify.Name = "contextMenuStripNotify";
			this.contextMenuStripNotify.Size = new System.Drawing.Size(134, 70);
			// 
			// showHideToolStripMenuItemShowHide
			// 
			this.showHideToolStripMenuItemShowHide.Name = "showHideToolStripMenuItemShowHide";
			this.showHideToolStripMenuItemShowHide.Size = new System.Drawing.Size(133, 22);
			this.showHideToolStripMenuItemShowHide.Text = "Show/Hide";
			this.showHideToolStripMenuItemShowHide.Click += new System.EventHandler(this.showHideToolStripMenuItemShowHide_Click);
			// 
			// startStopToolStripMenuItemStartStop
			// 
			this.startStopToolStripMenuItemStartStop.Name = "startStopToolStripMenuItemStartStop";
			this.startStopToolStripMenuItemStartStop.Size = new System.Drawing.Size(133, 22);
			this.startStopToolStripMenuItemStartStop.Text = "Start/Stop";
			this.startStopToolStripMenuItemStartStop.Click += new System.EventHandler(this.startStopToolStripMenuItemStartStop_Click);
			// 
			// exitToolStripMenuItemExit
			// 
			this.exitToolStripMenuItemExit.Name = "exitToolStripMenuItemExit";
			this.exitToolStripMenuItemExit.Size = new System.Drawing.Size(133, 22);
			this.exitToolStripMenuItemExit.Text = "Exit";
			this.exitToolStripMenuItemExit.Click += new System.EventHandler(this.exitToolStripMenuItemExit_Click);
			// 
			// timerClick
			// 
			this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
			// 
			// checkBoxIcon
			// 
			this.checkBoxIcon.AutoSize = true;
			this.checkBoxIcon.Location = new System.Drawing.Point(9, 66);
			this.checkBoxIcon.Name = "checkBoxIcon";
			this.checkBoxIcon.Size = new System.Drawing.Size(125, 17);
			this.checkBoxIcon.TabIndex = 1;
			this.checkBoxIcon.Text = "Show icon in taskbar";
			this.checkBoxIcon.UseVisualStyleBackColor = true;
			this.checkBoxIcon.CheckedChanged += new System.EventHandler(this.checkBoxIcon_CheckedChanged);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 225);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.progressBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Main";
			this.Text = "Timer";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPageTime.ResumeLayout(false);
			this.tabPageTime.PerformLayout();
			this.tabPageTasks.ResumeLayout(false);
			this.tabPageTasks.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.contextMenuStripNotify.ResumeLayout(false);
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
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.Timer timerAlarm;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.CheckBox checkBoxOnTop;
		private System.Windows.Forms.CheckBox checkBoxAlarm;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
		private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItemShowHide;
		private System.Windows.Forms.ToolStripMenuItem startStopToolStripMenuItemStartStop;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItemExit;
		private System.Windows.Forms.Timer timerClick;
		private System.Windows.Forms.CheckBox checkBoxIcon;
    }
}

