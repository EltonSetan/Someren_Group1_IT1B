using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    internal class SupervisorDao : BaseDao
    {
        public List<Lecturer> GetSupervisorsForActivity(int activityId)
        {
            string query = @"SELECT l.LecturerId, l.FirstName, l.LastName
                             FROM dbo.ActivitySupervisor s
                             INNER JOIN dbo.Lecturer l ON s.LecturerId = l.LecturerId
                             WHERE s.ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activityId)
            };
            return ReadLecturers(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Lecturer> GetNonSupervisorsForActivity(int activityId)
        {
            string query = @"SELECT l.LecturerId, l.FirstName, l.LastName
                             FROM dbo.Lecturer l
                             WHERE l.LecturerId NOT IN
                             (SELECT s.LecturerId FROM dbo.ActivitySupervisor s WHERE s.ActivityId = @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activityId)
            };
            return ReadLecturers(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddSupervisorToActivity(int activityId, int lecturerId)
        {
            string query = @"INSERT INTO dbo.ActivitySupervisor (ActivityId, LecturerId)
                             VALUES (@ActivityId, @LecturerId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activityId),
                new SqlParameter("@LecturerId", lecturerId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveSupervisorFromActivity(int activityId, int lecturerId)
        {
            string query = @"DELETE FROM dbo.ActivitySupervisor
                             WHERE ActivityId = @ActivityId AND LecturerId = @LecturerId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activityId),
                new SqlParameter("@LecturerId", lecturerId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Lecturer> ReadLecturers(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    Id = (int)dr["LecturerId"],
                    FirstName = (string)dr["FirstName"],
                    LastName = (string)dr["LastName"]
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
