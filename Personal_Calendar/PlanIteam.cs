using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Calendar
{
    public class PlanIteam
    {
        
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        /// <summary>
        /// //////////
        /// </summary>
        private string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }

        /// <summary>
        /// ///////////////
        /// </summary>
        private Point fromTime;
        public Point FromTime
        {
            get { return fromTime; }
            set { fromTime = value; }
        }

        /// <summary>
        /// //////////
        /// </summary>
        private Point toTime;
        public Point ToTime
        {
            get { return toTime; }
            set { toTime = value; }
        }

        /// <summary>
        /// ///////
        /// </summary>
        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public static List<string> ListStatus = new List<string>() { "DONE", "DOING", "COMING", "MISSED"};
    }
    public enum EPlanIteam
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }
}
