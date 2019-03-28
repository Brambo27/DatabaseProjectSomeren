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
    public class Teacher_DAO : Base
    {

        public List<Teacher> Db_Get_All_Teachers()
        {
            string query = "SELECT Docent_Nummer, Naam, Is_Begeleider FROM Docent";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void UpgradeTeacherToSupervisor(string teacherNumber)
        {
            string query = "UPDATE Docent SET Is_Begeleider = 1 WHERE Docent_Nummer = '"+ teacherNumber +"'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DowngradeSupervisorToTeacher(string teacherNumber)
        {
            string query = "UPDATE Docent SET Is_Begeleider = 0 WHERE Docent_Nummer = '" + teacherNumber + "'";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {

                    Number = (int)dr["Docent_Nummer"],
                    Name = (String)(dr["Naam"].ToString()),
                    IsSupervisor = (bool)dr["Is_Begeleider"]

                };
                teachers.Add(teacher);
            }
            return teachers;
        }
    }
}
