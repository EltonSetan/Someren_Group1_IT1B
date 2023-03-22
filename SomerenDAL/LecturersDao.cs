using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class LecturersDao:BaseDao
    {
        public List<Teacher> GetAllTeachers()
        {
            string query = "SELECT LecturerId, FirstName, LastName, Age, TelephoneNumber, RoomId, isSupervisor FROM [Lecturer]";
            
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers= new List<Teacher>();
            
            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["LecturerId"],
                    Name = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    Age = (int)dr["Age"],
                    TelephoneNumber = (int)dr["TelephoneNumber"],
                    RoomId = (int)dr["RoomId"],
                    isSupervisor = dr["isSupervisor"].ToString(),
                    //DrinkId = (int)dr["DrinkId"],
                };
                teachers.Add(teacher);
            }
            return teachers;
            return teachers;
        }
    }
}
