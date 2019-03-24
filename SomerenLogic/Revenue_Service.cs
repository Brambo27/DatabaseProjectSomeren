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
    public class Revenue_Service
    { 
        Revenue_DAO revenue_db = new Revenue_DAO();

        public List<Revenue> GetRevenue()
    {
            try
            {
                List<Revenue> revenue = revenue_db.Db_Get_All_Revenue();
                return revenue;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake revenue to the list to make sure the rest of the application continues working!
                List<Revenue> revenue = new List<Revenue>();
                Revenue a = new Revenue();
                a.Price = 2;
                a.StudentNumber = 333;
                a.Date = Convert.ToDateTime("13/05/2019");
                revenue.Add(a);
                Revenue b = new Revenue();
                b.Price = 2;
                b.StudentNumber = 666;
                b.Date = Convert.ToDateTime("14/05/2019");
                revenue.Add(b);
                return revenue;
                //throw new Exception("Someren couldn't connect to the database");
            }

    }
}
}
