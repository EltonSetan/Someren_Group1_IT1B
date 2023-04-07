using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;

namespace SomerenDAL
{
    public class SupervisorDao : BaseDao
    {
        public List<Teacher> GetSupervisorsForActivity(int activityId)
        {
            string query = @"SELECT l.LecturerId, l.FirstName, l.LastName
                             FROM dbo.Supervise s
                             JOIN dbo.Lecturer l ON s.LecturerId = l.LecturerId
                             WHERE s.ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activityId)
            };
            return ReadLecturers(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Teacher> GetNonSupervisorsForActivity(int activityId)
        {
            string query = @"SELECT l.LecturerId, l.FirstName, l.LastName
                     FROM dbo.Lecturer l
                     WHERE l.LecturerId NOT IN (SELECT s.LecturerId FROM dbo.Supervise s WHERE s.ActivityId = @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@ActivityId", activityId)
            };
            return ReadLecturers(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddSupervisorToActivity(int activityId, int lecturerId)
        {
            // Check if the lecturer exists in the Lecturer table
            string checkQuery = @"SELECT COUNT(*) FROM dbo.Lecturer WHERE LecturerId = @LecturerId";
            SqlParameter[] checkParameters = new SqlParameter[]
            {
        new SqlParameter("@LecturerId", lecturerId)
            };
            DataTable result = ExecuteSelectQuery(checkQuery, checkParameters);
            int lecturerCount = Convert.ToInt32(result.Rows[0][0]);

            if (lecturerCount > 0)
            {
                // Proceed with the insert operation
                string query = @"INSERT INTO dbo.Supervise (ActivityId, LecturerId)
                         VALUES (@ActivityId, @LecturerId)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@ActivityId", activityId),
            new SqlParameter("@LecturerId", lecturerId)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
            else
            {
                // Handle the case where the lecturer doesn't exist in the Lecturer table
                // You can throw an exception, display a message, or handle it in another way
                throw new InvalidOperationException("The lecturer does not exist in the Lecturer table.");
            }
        }

        public void RemoveSupervisorFromActivity(int activityId, int lecturerId)
        {
            string query = @"DELETE FROM dbo.Supervise
                     WHERE ActivityId = @ActivityId AND LecturerId = @LecturerId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activityId),
                new SqlParameter("@LecturerId", lecturerId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }


        public List<Teacher> GetAllSupervisors()
        {
            string query = @"SELECT LecturerId, FirstName, LastName
                             FROM dbo.Lecturer
                             WHERE isSupervisor = 'Yes'";
            SqlParameter[] sqlParameters = new SqlParameter[] { };
            return ReadLecturers(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadLecturers(DataTable dataTable)
        {
            List<Teacher> lecturers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher lecturer = new Teacher()
                {
                    Id = (int)dr["LecturerId"],
                    Name = (string)dr["FirstName"],
                    LastName = (string)dr["LastName"]
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
