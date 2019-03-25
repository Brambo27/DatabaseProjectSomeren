using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Drank_Service
    {
        Drankvoorraad_DAO Drank_db = new Drankvoorraad_DAO();

        public void UpdateVoorraad(string drankNaam, string value)
        {
            Drank_db.UpdateVoorraad(drankNaam, value);
        }

        public void UpdateNaam(string drankNaam, string value)
        {
            Drank_db.UpdateNaam(drankNaam, value);
        }

        public List<Drank> GetDrank()
        {
            try
            {
                List<Drank> Drank = Drank_db.Db_Get_All_Drank();
                return Drank;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake Drank to the list to make sure the rest of the application continues working!
                List<Drank> Drank = new List<Drank>();
                Drank a = new Drank();
                a.Name = "Test Drank";
                a.Number = 1;
                a.Voorraad = 5;
                a.Prijs = 3;
                Drank.Add(a);
                Drank b = new Drank();
                b.Name = "Test Drank";
                b.Number = 2;
                b.Voorraad = 20;
                b.Prijs = 2;
                Drank.Add(b);
                return Drank;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
