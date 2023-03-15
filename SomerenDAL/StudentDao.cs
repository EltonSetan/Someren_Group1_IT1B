using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    
    public class StudentDao : BaseDao
    {
        public List<Student> GetAllStudents()
        {
            string query = "SELECT StudentId, FirstName, LastName, TelephoneNumber, StudentNumber, Class, RoomId, DrinkId FROM [Student]";
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
                    Id = (int)dr["StudentId"],
                    FirstName = dr["FirstName"].ToString(), 
                    LastName = dr["LastName"].ToString(),//Added
                    //Age = (int)dr["StudentAge"], //added
                    //BirthDate = (DateTime)dr["StudentBirthDate"], //Added
                    TelephoneNumber = (int)dr["TelephoneNumber"],//Added
                    StudentNumber = (int)dr["StudentNumber"],
                    Class = (string)dr["Class"],
                    RoomId = (int)dr["RoomId"],
                    DrinkId = (int)dr["DrinkId"],
                };
                students.Add(student);
            }
            return students;
        }
    }
}