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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTime = new System.Windows.Forms.TabPage();
            this.tabPageTasks = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(263, 252);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTime
            // 
            this.tabPageTime.Location = new System.Drawing.Point(4, 22);
            this.tabPageTime.Name = "tabPageTime";
            this.tabPageTime.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTime.Size = new System.Drawing.Size(255, 226);
            this.tabPageTime.TabIndex = 0;
            this.tabPageTime.Text = "Time";
            this.tabPageTime.UseVisualStyleBackColor = true;
            // 
            // tabPageTasks
            // 
            this.tabPageTasks.Location = new System.Drawing.Point(4, 22);
            this.tabPageTasks.Name = "tabPageTasks";
            this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTasks.Size = new System.Drawing.Size(275, 237);
            this.tabPageTasks.TabIndex = 1;
            this.tabPageTasks.Text = "Tasks";
            this.tabPageTasks.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTime;
        private System.Windows.Forms.TabPage tabPageTasks;
    }
}

