using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class Gebruiker_DAO : Base
    {
        public void AddUser(string naam, string email, bool requestAdminRights)
        {
            string query = "INSERT INTO gebruiker (naam, email, isAdmin, adminAanvraag)" +
                "VALUES ('"+ naam +"', '"+ email +"', 'false', '"+ requestAdminRights +"' )";

            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public bool isUserAdmin(string naam, string email)
        {
            string query = "SELECT isAdmin FROM gebruiker WHERE naam = '"+ naam +"' AND email = '"+ email +"'";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadIsAdminColumn(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Gebruiker> GetUserMetAdminAanvraag()
        {
            string query = "SELECT gebruiker_ID, naam, email FROM gebruiker WHERE adminAanvraag = '1'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadUserTable(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpdateAdminRights(bool SetRightsTo, string gebruiker_ID)
        {
            string query = "UPDATE gebruiker SET isAdmin = '"+ SetRightsTo +"' WHERE gebruiker_ID = '"+ gebruiker_ID +"'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdateAdminRequestStatus(bool SetStatusTo, string gebruiker_ID)
        {
            string query = "UPDATE gebruiker SET adminAanvraag = '" + SetStatusTo + "' WHERE gebruiker_ID = '"+ gebruiker_ID + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);
        }

        public void UpdatePassword(string email, string newPassword, string newSecretQuestion, string newSecretAnswer)
        {
            string query = "UPDATE gebruiker SET wachtwoord = '" + newPassword + "', geheimeVraag = '" + newSecretQuestion+ "', geheimAntwoord = '" + newSecretAnswer + "' WHERE email = '" + email + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public List<Gebruiker> Db_Get_All_Gebruikers()
        {
            string query = "SELECT naam, email, wachtwoord, geheimeVraag, geheimAntwoord FROM gebruiker";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return GetGebruikers(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Gebruiker> ReadUserTable(DataTable dataTable)
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Gebruiker gebruiker = new Gebruiker()
                {
                    Naam = (string)dr["naam"],
                    Email = (string)dr["email"],
                    Gebruiker_ID = (int)dr["gebruiker_ID"]
                };
                gebruikers.Add(gebruiker);
            }
            return gebruikers;
        }

        private List<Gebruiker> GetGebruikers(DataTable dataTable)
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Gebruiker gebruiker = new Gebruiker()
                {
                    Naam = (string)dr["naam"],
                    Email = (string)dr["email"],
                    Wachtwoord = (string)dr["wachtwoord"],
                    GeheimeVraag = (string)dr["geheimeVraag"],
                    GeheimeAntwoord = (string)dr["geheimAntwoord"]
                };
                gebruikers.Add(gebruiker);
            }
            return gebruikers;
        }

        private bool ReadIsAdminColumn(DataTable dataTable)
        {
            bool isAdmin = false;

            foreach (DataRow dr in dataTable.Rows)
            {
                isAdmin = (bool)dr["isAdmin"];
            }
            return isAdmin;
        }
    }
}
