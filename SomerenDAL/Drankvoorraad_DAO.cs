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
    public class Drankvoorraad_DAO : Base
    {
      
        public List<Drank> Db_Get_All_Drank()
        {
            string query = "SELECT Drank_ID, Naam, Prijs, Voorraad " +
                "FROM Drank AS d JOIN Voorraadsysteem AS v ON d.Wordt_Bijgehouden=v.Voorraadsysteem_ID " +
                "WHERE Voorraad > 1 AND Prijs > 1 AND NOT Naam LIKE'Water' AND NOT Naam LIKE'Sinas' AND NOT Naam LIKE'Kersensap' " +
                "ORDER BY Voorraad DESC, Prijs DESC";
            //string query = "SELECT Drank_ID, Naam, Prijs, Voorraad FROM Drank AS d JOIN Voorraadsysteem AS v ON d.Wordt_Bijgehouden=v.Voorraadsysteem_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Drank> ReadTables(DataTable dataTable)
        {
            List<Drank> dranken = new List<Drank>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drank drank = new Drank()
                {
                    Number = (int)dr["Drank_ID"],
                    Name = (String)(dr["Naam"].ToString()),
                    Voorraad = (int)dr["Voorraad"],
                    Prijs = (int)dr["Prijs"] 
                };
                dranken.Add(drank);
            }
            return dranken;
        }
    }
}
