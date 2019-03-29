using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Schedule_Service
    {
        Schedule_DAO schedule_db = new Schedule_DAO();

        public List<Schedule> GetSchedules()
        {
            try
            {
                List<Schedule> schedules = schedule_db.Db_Get_All_Schedules();
                return schedules;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Schedule> schedule = new List<Schedule>();
                Schedule a = new Schedule();
                a.Activity = "fightclub";
                a.Supervisors = 4;
                a.StartDate = DateTime.Parse("1990-07-04");
                a.StartTime = TimeSpan.Parse("15:00");
                a.EndTime = TimeSpan.Parse("16:00");
                schedule.Add(a);
                Schedule b = new Schedule();
                b.Activity = "bloemen plukken";
                b.Supervisors = 1;
                b.StartDate = DateTime.Parse("1990-07-04");
                b.StartTime = TimeSpan.Parse("15:00");
                b.EndTime = TimeSpan.Parse("16:00");
                schedule.Add(b);
                return schedule;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
