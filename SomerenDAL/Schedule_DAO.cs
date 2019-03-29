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
            string query = "SELECT A.Soort, begeleider, datum, tijdStart, tijdEind FROM Rooster AS R JOIN Activiteit AS A ON A.Activiteit_ID = R.activiteit";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Schedule> ReadTables(DataTable dataTable)
        {
            List<Schedule> schedules = new List<Schedule>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Schedule schedule = new Schedule()
                {
                    Activity = (String)dr["Soort"],
                    Supervisors = (int)dr["begeleider"],
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
