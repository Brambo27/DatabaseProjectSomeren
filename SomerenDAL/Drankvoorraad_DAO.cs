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
            string query = "SELECT Drank_ID, Naam, Prijs, Voorraad, Wordt_Bijgehouden " +
                "FROM Drank AS d JOIN Voorraadsysteem AS v ON d.Wordt_Bijgehouden=v.Voorraadsysteem_ID " +
                "WHERE Voorraad > 1 AND Prijs > 1 AND NOT Naam LIKE'Water' AND NOT Naam LIKE'Sinas' AND NOT Naam LIKE'Kersensap' " +
                "ORDER BY Voorraad DESC, Prijs DESC";
            //string query = "SELECT Drank_ID, Naam, Prijs, Voorraad FROM Drank AS d JOIN Voorraadsysteem AS v ON d.Wordt_Bijgehouden=v.Voorraadsysteem_ID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdatePrijs(string drankNaam, string value)
        {
            string query = "UPDATE Drank SET Prijs = '" + value + "' WHERE Naam LIKE '" + drankNaam + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public string GetVoorraadID(string naam)
        {
            string voorraadID = "";
            //TODO Check if null
            string query = "SELECT Wordt_Bijgehouden FROM Drank WHERE Naam LIKE '" + naam + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];


            DataTable dataTable = ExecuteSelectQuery(query, sqlParameters);

            DataRow dr = dataTable.Rows[0];

            voorraadID = (String)dr["Wordt_Bijgehouden"].ToString();

            return voorraadID;
        }

        public void UpdateVoorraad(string drankNaam, string value)
        {
            string Voorraad_ID = GetVoorraadID(drankNaam);

            string query = "UPDATE Voorraadsysteem SET Voorraad = '" + value + "' WHERE Voorraadsysteem_ID =" + Voorraad_ID + "";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void NieuwDrankje(string naam, string voorraad, string prijs)
        {
            string query = "BEGIN TRANSACTION " +
                "DECLARE @DataID int;" +
                "INSERT INTO Voorraadsysteem(Voorraad) VALUES(" + voorraad + "); " +
                "SELECT @DataID = scope_identity(); " +
                "INSERT INTO Drank(Naam, Prijs, Wordt_Bijgehouden) VALUES('" + naam + "' , '" + prijs + "', @DataID) " +
                "COMMIT";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateNaam(string drankNaam, string value)
        {
            string query = "UPDATE Drank SET Naam = '" + value + "' WHERE Naam LIKE '"+ drankNaam +"'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
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
                    Prijs = (int)dr["Prijs"],
                    Voorraad_ID = (int)dr["Wordt_Bijgehouden"]
                };
                dranken.Add(drank);
            }
            return dranken;
        }
    }
}
