using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentId, FirstName, LastName, Class, TelephoneNumber ,StudentNumber, RoomId, DrinkId  FROM [Student]";
           
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["StudentId"],
                    Name = dr["FirstName"].ToString(), //,+ " " + dr["LastName"].ToString(),
                    TelephoneNumber = (int)dr["TelephoneNumber"],
                    Class = dr["Class"].ToString(),
                    RoomId = (int)dr["RoomId"],
                    DrinkId = (int)dr["DrinkId"],
                    StudentNumber = (int)dr["StudentNumber"],
                    //BirthDate = (DateTime)dr["guhu"],
                      LastName = dr["LastName"].ToString(),
                };
                students.Add(student);
            }
            return students;
        }
    }
}