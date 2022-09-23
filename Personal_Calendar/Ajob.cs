using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Calendar
{
    public partial class Ajob : UserControl
    {

        private PlanIteam job;
        public PlanIteam Job
        {
            get { return job; }
            set { job = value; }
        }
        public Ajob(PlanIteam job)
        {
            InitializeComponent();
            cbStatus.DataSource = PlanIteam.ListStatus;
            this.Job = job;
            ShowInfo();
        }
        void ShowInfo()
        {
            txtJob.Text = Job.Job;
            nmFromHours.Value = Job.FromTime.X;
            nmFromMinute.Value = Job.FromTime.Y;
            nmToHours.Value = Job.ToTime.X;
            nmToMinute.Value = Job.ToTime.Y;
            cbStatus.SelectedIndex = PlanIteam.ListStatus.IndexOf(Job.Status);
            cbDone.Checked = PlanIteam.ListStatus.IndexOf(Job.Status) == (int)EPlanIteam.DONE ? true : false;   

        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(deleted != null)
                deleted(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Job = txtJob.Text;
            Job.FromTime = new Point((int)nmFromHours.Value, (int)nmFromMinute.Value);
            Job.ToTime = new Point((int)nmToHours.Value, (int)nmToMinute.Value);
            Job.Status = PlanIteam.ListStatus[cbStatus.SelectedIndex];

            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void cbDone_CheckedChanged(object sender, EventArgs e)
        {
            cbStatus.SelectedIndex = cbDone.Checked ? (int)EPlanIteam.DONE : (int)EPlanIteam.DOING;
        }
    }
}
