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
    public class Activity_Service
    {
        Activity_DAO activity_db = new Activity_DAO();
        public void NewActivity(string naam, int students, int docents)
        {
            activity_db.New_Activity(naam, students, docents);
        }
        public void UpdateName(string value, int ActivityID)
        {
            activity_db.UpdateName(value, ActivityID);
        }
        public void UpdateStudent(string value, int ActivityID)
        {
            activity_db.UpdateStudents(value, ActivityID);
        }
        public void UpdateDocent(string value, int ActivityID)
        {
            activity_db.UpdateDocents(value, ActivityID);
        }
        public void Delete(int ActivityID)
        {
            activity_db.DeleteRow(ActivityID);
        }
        public List<Activity> GetActivities()
        {
            try
            {
                List<Activity> activity = activity_db.Db_Get_All_Activitys();
                return activity;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Activity> activity = new List<Activity>();
                Activity a = new Activity();
                a.activityID = 999;
                a.activityName = "Test Activity";
                a.numberOfStudents = 99;
                a.numerOfDocents = 98;
                activity.Add(a);
                Activity b = new Activity();
                b.activityID = 1000;
                b.activityName = "definitely not a Test Activity";
                b.numberOfStudents = 98;
                b.numerOfDocents = 99;
                activity.Add(b);
                return activity;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}

