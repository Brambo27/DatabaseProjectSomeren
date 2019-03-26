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
    public class Activity_DAO : Base
    {
        //schrik
        public List<Activity> Db_Get_All_Activitys()
        {
            string query = "SELECT Activiteit_ID, Soort, aantalStudenten, aantalBegeleiders FROM Activiteit";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void New_Activity(string naam, int students, int docents)
        {
            string query = "INSERT INTO Activiteit(Soort, aantalStudenten, aantalBegeleiders) VALUES('"+naam+"', "+ students +", "+ docents +")";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateName(string value, int ActivityID)
        {
            string query = "UPDATE Activiteit SET Soort = '"+ value +"' WHERE Activiteit_ID = "+ ActivityID +"";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateStudents(string value, int ActivityID)
        {
            string query = "UPDATE Activiteit SET aantalStudenten = '" + value + "' WHERE Activiteit_ID = " + ActivityID + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateDocents(string value, int ActivityID)
        {
            string query = "UPDATE Activiteit SET aantalBegeleiders = '" + value + "' WHERE Activiteit_ID = " + ActivityID + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteRow(int ActivityID)
        {
            string query = "DELETE FROM Activiteit WHERE Activiteit_ID = " + ActivityID + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    activityID = (int)dr["Activiteit_ID"],
                    activityName = (String)(dr["soort"].ToString()),
                    numberOfStudents = (int)dr["aantalStudenten"],
                    numerOfDocents = (int)dr["aantalBegeleiders"]
                };
                activities.Add(activity);
            }
            return activities;
        }

    }
}
