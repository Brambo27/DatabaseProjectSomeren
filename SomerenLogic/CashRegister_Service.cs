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
    public class CashRegister_Service
    {
        CashRegister_DAO cashregister_db = new CashRegister_DAO();

        public List<CashRegister> GetCashRegisters()
        {
            try
            {
                List<CashRegister> cashRegisters = cashregister_db.Db_Get_All_CashRegister();
                return cashRegisters;
            }
            catch (Exception e)
            {
                // something went wrong connecting to the database, so we will add a fake Cashregister to the list to make sure the rest of the application continues working!
                List<CashRegister> cashRegister = new List<CashRegister>();
                CashRegister a = new CashRegister();
                a.StudentNummer = 999999;
                a.StudentNaam = "Mr Test";
                a.DrankID = 999;
                a.DrankNaam = "slootwater";
                cashRegister.Add(a);
                CashRegister b = new CashRegister();
                b.StudentNummer = 999998;
                b.StudentNaam = "Mrs Test";
                b.DrankID = 998;
                b.DrankNaam = "zeewater";
                cashRegister.Add(b);
                return cashRegister;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
