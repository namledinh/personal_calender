namespace Personal_Calendar
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnToday = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nmNodify = new System.Windows.Forms.NumericUpDown();
            this.cbThongbao = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMatrix = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.btnSunday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnTeusday = new System.Windows.Forms.Button();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.tmNotify = new System.Windows.Forms.Timer(this.components);
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNodify)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkDate
            // 
            this.dtpkDate.Location = new System.Drawing.Point(606, 2);
            this.dtpkDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(265, 23);
            this.dtpkDate.TabIndex = 0;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(898, 2);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(100, 27);
            this.btnToday.TabIndex = 1;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.dtpkDate);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 32);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nmNodify);
            this.panel5.Controls.Add(this.cbThongbao);
            this.panel5.Location = new System.Drawing.Point(4, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 29);
            this.panel5.TabIndex = 0;
            // 
            // nmNodify
            // 
            this.nmNodify.Enabled = false;
            this.nmNodify.Location = new System.Drawing.Point(120, 1);
            this.nmNodify.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.nmNodify.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNodify.Name = "nmNodify";
            this.nmNodify.Size = new System.Drawing.Size(72, 23);
            this.nmNodify.TabIndex = 1;
            this.nmNodify.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmNodify.ValueChanged += new System.EventHandler(this.nmNodify_ValueChanged);
            // 
            // cbThongbao
            // 
            this.cbThongbao.AutoSize = true;
            this.cbThongbao.Location = new System.Drawing.Point(0, 2);
            this.cbThongbao.Name = "cbThongbao";
            this.cbThongbao.Size = new System.Drawing.Size(89, 19);
            this.cbThongbao.TabIndex = 0;
            this.cbThongbao.Text = "Thông báo";
            this.cbThongbao.UseVisualStyleBackColor = true;
            this.cbThongbao.CheckedChanged += new System.EventHandler(this.cbThongbao_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMatrix);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(4, 53);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1004, 465);
            this.panel2.TabIndex = 3;
            // 
            // pnlMatrix
            // 
            this.pnlMatrix.Location = new System.Drawing.Point(124, 92);
            this.pnlMatrix.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlMatrix.Name = "pnlMatrix";
            this.pnlMatrix.Size = new System.Drawing.Size(747, 363);
            this.pnlMatrix.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextMonth);
            this.panel3.Controls.Add(this.btnSunday);
            this.panel3.Controls.Add(this.btnSaturday);
            this.panel3.Controls.Add(this.btnFriday);
            this.panel3.Controls.Add(this.btnThursday);
            this.panel3.Controls.Add(this.btnWednesday);
            this.panel3.Controls.Add(this.btnTeusday);
            this.panel3.Controls.Add(this.btnMonday);
            this.panel3.Controls.Add(this.btnPrevious);
            this.panel3.Location = new System.Drawing.Point(4, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 83);
            this.panel3.TabIndex = 0;
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(894, 14);
            this.btnNextMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(100, 54);
            this.btnNextMonth.TabIndex = 10;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.Location = new System.Drawing.Point(768, 14);
            this.btnSunday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(100, 54);
            this.btnSunday.TabIndex = 9;
            this.btnSunday.Text = "Chủ nhật";
            this.btnSunday.UseVisualStyleBackColor = true;
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(660, 14);
            this.btnSaturday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(100, 54);
            this.btnSaturday.TabIndex = 8;
            this.btnSaturday.Text = "Thứ 7";
            this.btnSaturday.UseVisualStyleBackColor = true;
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(552, 14);
            this.btnFriday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(100, 54);
            this.btnFriday.TabIndex = 7;
            this.btnFriday.Text = "Thứ 6";
            this.btnFriday.UseVisualStyleBackColor = true;
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(444, 14);
            this.btnThursday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(100, 54);
            this.btnThursday.TabIndex = 6;
            this.btnThursday.Text = "Thứ 5";
            this.btnThursday.UseVisualStyleBackColor = true;
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(336, 14);
            this.btnWednesday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(100, 54);
            this.btnWednesday.TabIndex = 5;
            this.btnWednesday.Text = "Thứ 4";
            this.btnWednesday.UseVisualStyleBackColor = true;
            // 
            // btnTeusday
            // 
            this.btnTeusday.Location = new System.Drawing.Point(228, 14);
            this.btnTeusday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTeusday.Name = "btnTeusday";
            this.btnTeusday.Size = new System.Drawing.Size(100, 54);
            this.btnTeusday.TabIndex = 4;
            this.btnTeusday.Text = "Thứ 3";
            this.btnTeusday.UseVisualStyleBackColor = true;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(120, 14);
            this.btnMonday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(100, 54);
            this.btnMonday.TabIndex = 3;
            this.btnMonday.Text = "Thứ 2";
            this.btnMonday.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(0, 14);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 54);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Tháng trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // tmNotify
            // 
            this.tmNotify.Enabled = true;
            this.tmNotify.Interval = 60000;
            this.tmNotify.Tick += new System.EventHandler(this.tmNotify_Tick);
            // 
            // Notify
            // 
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "notifyIcon1";
            this.Notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 529);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch cá nhân";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmNodify)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMatrix;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Button btnSunday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnTeusday;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.NumericUpDown nmNodify;
        private System.Windows.Forms.CheckBox cbThongbao;
        private System.Windows.Forms.Timer tmNotify;
        private System.Windows.Forms.NotifyIcon Notify;
    }
}

