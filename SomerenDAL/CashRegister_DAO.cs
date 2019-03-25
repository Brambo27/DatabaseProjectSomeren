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
    public class CashRegister_DAO : Base
    {
        public List<CashRegister> Db_Get_All_CashRegister()
        {
            string query = "SELECT Drank_ID, Naam FROM Drank";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Db_Bar_Update_verkoop(int drank_ID, int student_Nummer)
        {
            DateTime datum = DateTime.Today;
            string query = "INSERT INTO Bar_Verkoop (Transactienummer, Drank_ID, Student_Nummer, Datum) VALUES('"+ 1010 +"', '" + drank_ID +"', '"+ student_Nummer + "', CURRENT_TIMESTAMP)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteSelectQuery(query, sqlParameters);
        }

        private List<CashRegister> ReadTables(DataTable dataTable)
        {
            List<CashRegister> cashRegisters = new List<CashRegister>();

            foreach (DataRow dr in dataTable.Rows)
            {
                CashRegister cashRegister = new CashRegister()
                {
                    DrankID = (int)dr["Drank_ID"],
                    DrankNaam = (String)(dr["Naam"].ToString())
                };
                cashRegisters.Add(cashRegister);
            }
            return cashRegisters;
        }

    }
}

