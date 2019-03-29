using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Schedule_DAO : Base
    {

        public List<Schedule> Db_Get_All_Schedules()
        {
            string query = "SELECT rooster_ID, activiteit_ID, datum, tijdStart, tijdEind FROM Rooster";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void SwapActivityTime(string firstRoosterID, string secondRoosterID)
        {
            //Select de tijd van beide rooster items
            string query = "SELECT tijdStart, tijdEind, datum FROM Rooster WHERE rooster_ID = '"+ firstRoosterID + "' OR rooster_ID = '" + secondRoosterID + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<Schedule> schedules = ReadTablesLite(ExecuteSelectQuery(query, sqlParameters));
            string firstRoosterStartTime, firstRoosterEndTime, firstRoosterDatum, secondroosterStartTime, secondRoosterEndTime, secondRoosterDatum;

            firstRoosterStartTime = schedules[0].StartTime.ToString(@"hh\:mm");
            firstRoosterEndTime = schedules[0].EndTime.ToString(@"hh\:mm");
            firstRoosterDatum = schedules[0].StartDate.ToString("yyyy-MM-dd");

            secondroosterStartTime = schedules[1].StartTime.ToString(@"hh\:mm");
            secondRoosterEndTime = schedules[1].EndTime.ToString(@"hh\:mm");
            secondRoosterDatum = schedules[1].StartDate.ToString("yyyy-MM-dd");


            query = "UPDATE Rooster SET datum = '"+ firstRoosterDatum +"', tijdStart = '"+ firstRoosterStartTime +"', tijdEind = '"+ firstRoosterEndTime +"' WHERE rooster_ID = '"+ secondRoosterID +"'";
            ExecuteEditQuery(query, sqlParameters);
            query = "UPDATE Rooster SET datum = '" + secondRoosterDatum + "', tijdStart = '" + secondroosterStartTime + "', tijdEind = '" + secondRoosterEndTime + "' WHERE rooster_ID = '"+ firstRoosterID +"'";
            ExecuteEditQuery(query, sqlParameters);

        }

        private List<Schedule> ReadTablesLite(DataTable dataTable)
        {
            List<Schedule> schedules = new List<Schedule>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Schedule schedule = new Schedule()
                {
                    StartDate = (DateTime)dr["datum"],
                    StartTime = (TimeSpan)dr["tijdStart"],
                    EndTime = (TimeSpan)dr["tijdEind"]
                };
                schedules.Add(schedule);
            }
            return schedules;
        }

        private List<Schedule> ReadTables(DataTable dataTable)
        {
            List<Schedule> schedules = new List<Schedule>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Schedule schedule = new Schedule()
                {
                    ActivityID = (int)dr["activiteit_ID"],
                    RoosterID = (int)dr["rooster_ID"],
                    StartDate = (DateTime)dr["datum"],
                    StartTime = (TimeSpan)dr["tijdStart"],
                    EndTime = (TimeSpan)dr["tijdEind"]
                };
                schedules.Add(schedule);
            }
            return schedules;
        }

    }
}
