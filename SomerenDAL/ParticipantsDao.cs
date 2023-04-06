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
        //public List<Participants> GetAllParticipants()
        //{
        //    string query = @"SELECT s.StudentId, s.FirstName, s.LastName 
        //             FROM dbo.Student s
        //             JOIN dbo.ParticipatesIn  p ON s.StudentId = p.StudentId
        //              WHERE p.ActivityId = 4";

        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    return Readparticipants(ExecuteSelectQuery(query, sqlParameters));
        //}

        //private List<Participants> Readparticipants(DataTable dataTable)
        //{
        //    List<Participants> participants = new List<Participants>();

        //    foreach (DataRow dr in dataTable.Rows)
        //    {
        //        Participants participant = new Participants()
        //        {
        //            StudentId = (int)dr["StudentId"],
        //             FirstName= (string)dr["FirstName"],
        //            LastName = (string)dr["LastName"],                  
        //        };
        //        participants.Add(participant);
        //    }
        //    return participants;
        //}

        //public Participants GetById(int bookId)
        //{
        //    SqlParameter[] sqlParameters = new SqlParameter[0];
        //    SqlCommand command = new SqlCommand(
        //    "SELECT * FROM Books WHERE Id = @Id", dbConnection);
        //    command.Parameters.AddWithValue("@Id", bookId);
        //    SqlDataReader reader = command.ExecuteReader();
        //    Book book = null;
        //    if (reader.Read())
        //    {
        //        book = ReadBook(reader);
        //    }
        //    reader.Close();
        //    dbConnection.Close();
        //    return book;
        //}
        public List<Participants> GetParticipantsById(int ActivityId)
        {
            //string query = "SELECT s.StudentId, a.ActivityId FROM Students AS s JOIN ActivityStudent AS a ON a.ParticipantId = s.StudentId WHERE a.ActivityId = @ActivityId";
            //SqlParameter[] sqlParameters = new SqlParameter[1];
            //sqlParameters[0] = new SqlParameter("@ActivityId", ActivityId);
            //return ReadTables(ExecuteSelectQuery(query, sqlParameters));
            string query = @"SELECT s.StudentId, s.FirstName, s.LastName, 
                     FROM dbo.ParticipatesIn p
                   JOIN dbo.Student s  p ON s.StudentId = p.StudentId
                    WHERE p.ActivityId = @ActivityId";


            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", ActivityId)
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Participants> ReadTables(DataTable dataTable)
        {
            List<Participants> participants = new List<Participants>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participants participant = new Participants()
                {
                    //ParticipantId = (int)dr["StudentId"],
                    //ActivityId = (int)dr["ActivityId"],
                    StudentId = (int)dr["StudentId"],
                                FirstName= (string)dr["FirstName"],
                               LastName = (string)dr["LastName"], 

                };
                participants.Add(participant);
            }

            return participants;
        }
    }
}
