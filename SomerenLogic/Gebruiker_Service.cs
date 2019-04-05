using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Gebruiker_Service
    {
        Gebruiker_DAO gebruiker_db = new Gebruiker_DAO();

        public void AddUser(string naam, string email, bool requestAdminRights)
        {
            gebruiker_db.AddUser(naam, email, requestAdminRights);
        }

        public bool IsUserAdmin(string naam, string email)
        {
            return gebruiker_db.isUserAdmin(naam, email);
        }

        public List<Gebruiker> GetUserMetAdminAanvraag()
        {
            return gebruiker_db.GetUserMetAdminAanvraag();
        }

        public void UpdateAdminRights(bool SetRightsTo, string gebruiker_ID)
        {
            gebruiker_db.UpdateAdminRights(SetRightsTo, gebruiker_ID);
        }

        public void UpdateAdminAanvraagStaus(bool SetStatusTo, string gebruiker_ID)
        {
            gebruiker_db.UpdateAdminRequestStatus(SetStatusTo, gebruiker_ID);
        }

        public void ChangePassword(string email, string newPassword, string secretQuestion, string secretAnswer)
        {
            gebruiker_db.UpdatePassword(email, newPassword, secretQuestion, secretAnswer);
        }

        public List<Gebruiker> GetUsers()
        {
            return gebruiker_db.Db_Get_All_Gebruikers();
        }
    }

}
