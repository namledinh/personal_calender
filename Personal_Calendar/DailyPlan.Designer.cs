namespace Personal_Calendar
{
    partial class DailyPlan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlJob = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreviousDay = new System.Windows.Forms.Button();
            this.btnNextday = new System.Windows.Forms.Button();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsAddjob = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsToday = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlJob);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 388);
            this.panel1.TabIndex = 0;
            // 
            // pnlJob
            // 
            this.pnlJob.Location = new System.Drawing.Point(3, 44);
            this.pnlJob.Name = "pnlJob";
            this.pnlJob.Size = new System.Drawing.Size(1066, 333);
            this.pnlJob.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPreviousDay);
            this.panel2.Controls.Add(this.btnNextday);
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1066, 35);
            this.panel2.TabIndex = 0;
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Location = new System.Drawing.Point(9, 4);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Size = new System.Drawing.Size(94, 28);
            this.btnPreviousDay.TabIndex = 0;
            this.btnPreviousDay.Text = "Hôm qua";
            this.btnPreviousDay.UseVisualStyleBackColor = true;
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // btnNextday
            // 
            this.btnNextday.Location = new System.Drawing.Point(130, 4);
            this.btnNextday.Name = "btnNextday";
            this.btnNextday.Size = new System.Drawing.Size(94, 28);
            this.btnNextday.TabIndex = 1;
            this.btnNextday.Text = "Ngày mai";
            this.btnNextday.UseVisualStyleBackColor = true;
            this.btnNextday.Click += new System.EventHandler(this.btnNextday_Click);
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(254, 6);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(210, 20);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // mnsMain
            // 
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAddjob,
            this.mnsToday});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(1084, 24);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsAddjob
            // 
            this.mnsAddjob.Name = "mnsAddjob";
            this.mnsAddjob.Size = new System.Drawing.Size(73, 20);
            this.mnsAddjob.Text = "Thêm việc";
            this.mnsAddjob.Click += new System.EventHandler(this.mnsAddjob_Click);
            // 
            // mnsToday
            // 
            this.mnsToday.Name = "mnsToday";
            this.mnsToday.Size = new System.Drawing.Size(68, 20);
            this.mnsToday.Text = "Hôm nay";
            this.mnsToday.Click += new System.EventHandler(this.mnsToday_Click);
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnsMain);
            this.MainMenuStrip = this.mnsMain;
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyPlan";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsAddjob;
        private System.Windows.Forms.ToolStripMenuItem mnsToday;
        private System.Windows.Forms.Button btnPreviousDay;
        private System.Windows.Forms.Button btnNextday;
    }
}