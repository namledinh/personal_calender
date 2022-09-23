using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Calendar
{
    [Serializable]
    public class PlanData
    {
        private List<PlanIteam> job;
        public List<PlanIteam> Job
        {
            get { return job; }
            set { job = value; }
        }
    }
}
