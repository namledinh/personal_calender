namespace Personal_Calendar
{
    partial class Ajob
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDone = new System.Windows.Forms.CheckBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nmToMinute = new System.Windows.Forms.NumericUpDown();
            this.nmToHours = new System.Windows.Forms.NumericUpDown();
            this.nmFromMinute = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nmFromHours = new System.Windows.Forms.NumericUpDown();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbDone);
            this.panel1.Controls.Add(this.txtJob);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 38);
            this.panel1.TabIndex = 0;
            // 
            // cbDone
            // 
            this.cbDone.AutoSize = true;
            this.cbDone.Location = new System.Drawing.Point(5, 7);
            this.cbDone.Name = "cbDone";
            this.cbDone.Size = new System.Drawing.Size(15, 14);
            this.cbDone.TabIndex = 1;
            this.cbDone.UseVisualStyleBackColor = true;
            this.cbDone.CheckedChanged += new System.EventHandler(this.cbDone_CheckedChanged);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(26, 4);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(495, 24);
            this.txtJob.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmToMinute);
            this.panel2.Controls.Add(this.nmToHours);
            this.panel2.Controls.Add(this.nmFromMinute);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.nmFromHours);
            this.panel2.Location = new System.Drawing.Point(532, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 38);
            this.panel2.TabIndex = 1;
            // 
            // nmToMinute
            // 
            this.nmToMinute.Location = new System.Drawing.Point(224, 6);
            this.nmToMinute.Name = "nmToMinute";
            this.nmToMinute.Size = new System.Drawing.Size(48, 20);
            this.nmToMinute.TabIndex = 4;
            // 
            // nmToHours
            // 
            this.nmToHours.Location = new System.Drawing.Point(170, 6);
            this.nmToHours.Name = "nmToHours";
            this.nmToHours.Size = new System.Drawing.Size(48, 20);
            this.nmToHours.TabIndex = 3;
            // 
            // nmFromMinute
            // 
            this.nmFromMinute.Location = new System.Drawing.Point(58, 6);
            this.nmFromMinute.Name = "nmFromMinute";
            this.nmFromMinute.Size = new System.Drawing.Size(48, 20);
            this.nmFromMinute.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đến";
            // 
            // nmFromHours
            // 
            this.nmFromHours.Location = new System.Drawing.Point(4, 6);
            this.nmFromHours.Name = "nmFromHours";
            this.nmFromHours.Size = new System.Drawing.Size(48, 20);
            this.nmFromHours.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(816, 10);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(943, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(986, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Ajob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Ajob";
            this.Size = new System.Drawing.Size(1028, 46);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmToMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmToHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmFromHours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDone;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmToMinute;
        private System.Windows.Forms.NumericUpDown nmToHours;
        private System.Windows.Forms.NumericUpDown nmFromMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmFromHours;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}
