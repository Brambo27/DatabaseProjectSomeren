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
    public class Revenue_DAO : Base
    {

        public List<Revenue> Db_Get_All_Revenue()
        {
            string query = "SELECT Prijs, Student_Nummer, Datum FROM Bar_Verkoop AS B JOIN Drank AS D ON B.Drank_ID = D.Drank_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Revenue> ReadTables(DataTable dataTable)
        {
            List<Revenue> revenueReport = new List<Revenue>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Revenue revenue = new Revenue()
                {
                    Price = (int)dr["Prijs"],
                    StudentNumber = (int)dr["Student_Nummer"],
                    Date = (DateTime)dr["Datum"]
                };
                revenueReport.Add(revenue);
            }
            return revenueReport;
        }

    }
}
