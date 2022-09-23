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
    public partial class DailyPlan : Form
    {
        private DateTime date;
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="job"></param>
        private PlanData job;
        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="job"></param>
        /// 

        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        public DailyPlan( DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Job = job;
            fPanel.Width = pnlJob.Width;
            fPanel.Height = pnlJob.Height;  
            pnlJob.Controls.Add(fPanel);

            dtpkDate.Value = Date;

        }


        void ShowJobByDate(DateTime date)
        {
            fPanel.Controls.Clear();
            if (job != null && Job.Job != null)
            {
                List<PlanIteam> todayJob = GetJobByDay(date);
                for (int i = 0; i < GetJobByDay(date).Count; i++)
                {
                    AddJob(todayJob[i]);    
                    
                }
            }
        }

        private void Ajob_Deleted(object sender, EventArgs e)
        {
            Ajob uc = sender as Ajob;
            PlanIteam job = uc.Job;

            fPanel.Controls.Remove(uc);
            Job.Job.Remove(job);
        }

        private void Ajob_Edited(object sender, EventArgs e)
        {
            
        }

        List<PlanIteam> GetJobByDay(DateTime date)
        {
            return Job.Job.Where(x => x.Date.Year == date.Year && x.Date.Month == date.Month && x.Date.Day == date.Day).ToList();
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
        }

        private void btnNextday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(1);
        }

        private void mnsAddjob_Click(object sender, EventArgs e)
        {
            PlanIteam item = new PlanIteam() { Date = dtpkDate.Value};
            Job.Job.Add(item);
            AddJob(item);
        }


        void AddJob(PlanIteam job)
        {
            Ajob ajob = new Ajob(job);
            ajob.Edited += Ajob_Edited;
            ajob.Deleted += Ajob_Deleted;
            fPanel.Controls.Add(ajob);
        }
        private void mnsToday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Now;
        }
    }
}
