using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Schedule
    {
        public int RoosterID { get; set; }
        public int ActivityID { get; set; }
        public string Activity { get; set; }
        public int Supervisors { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}