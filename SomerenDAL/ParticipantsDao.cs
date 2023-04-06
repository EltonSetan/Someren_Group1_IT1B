using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SomerenDAL
{
    public class ParticipantsDao : BaseDao
    {
        public List<Participants> GetParticipantsById(int ActivityId)
        {
            string query = @"SELECT s.StudentId, s.FirstName, s.LastName
                     FROM dbo.Student s
                   JOIN dbo.ParticipatesIn  p ON s.StudentId = p.StudentId
                    WHERE p.ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", ActivityId)
            };
            return ReadStudents(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Participants> ReadStudents(DataTable dataTable)
        {
            List<Participants> participants = new List<Participants>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participants participant = new Participants()
                {
                    StudentId = (int)dr["StudentId"],
                    FirstName = (string)dr["FirstName"],
                    LastName = (string)dr["LastName"],

                };
                participants.Add(participant);
            }
            return participants;
        }

        public List<Participants> GetNonParticipantsById(int ActivityId)
        {
            string query = @"SELECT s.StudentId, s.FirstName, s.LastName
                     FROM dbo.Student s
                    WHERE s.StudentId NOT IN (SELECT p.StudentId FROM dbo.ParticipatesIn p WHERE p.ActivityId = @ActivityId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                 new SqlParameter("@ActivityId", ActivityId)
            };
            return ReadStudents(ExecuteSelectQuery(query, sqlParameters));
        }

        public void AddParticipants(int activityId, int studentId)
        {                           
            string query = @"INSERT INTO dbo.ParticipatesIn (ActivityId, StudentId)
                         VALUES (@ActivityId, @StudentId)";
            SqlParameter[] sqlParameters = new SqlParameter[]
                {
            new SqlParameter("@ActivityId", activityId),
            new SqlParameter("@StudentId", studentId)
                };
            ExecuteEditQuery(query, sqlParameters);          
        }

        public void RemoveParticipants(int activityId, int studentId)
        {
            string query = @"DELETE FROM dbo.ParticipatesIn
                     WHERE ActivityId = @ActivityId AND StudentId = @StudentId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
        new SqlParameter("@ActivityId", activityId),
        new SqlParameter("@StudentId", studentId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

    }
}
