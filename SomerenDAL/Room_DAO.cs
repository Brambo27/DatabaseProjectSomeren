﻿using System;
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
    public class Room_DAO : Base
    {
        public List<Room> Db_Get_All_Rooms()
        {
            string query = "SELECT Kamer_Nummer, Aantal_Bedden, is_docenten_kamer FROM Kamer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (int)dr["Kamer_Nummer"],
                    Capacity = (int)dr["Aantal_Bedden"],
                    Type = (bool)dr["is_docenten_kamer"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
