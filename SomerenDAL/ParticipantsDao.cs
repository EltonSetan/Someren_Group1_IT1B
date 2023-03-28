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
    public class ParticipantsDao : BaseDao
    {
        public List<Participants> GetAllParticipants()
        {
            string query = @"SELECT s.StudentId, s.FirstName, s.LastName 
                     FROM dbo.Student s
                     JOIN ParticipatesIn  p ON s.StudentId = p.StudentId";
                      SqlParameter[] sqlParameters = new SqlParameter[0];
            return Readparticipants(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Participants> Readparticipants(DataTable dataTable)
        {
            List<Participants> participants = new List<Participants>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participants participant = new Participants()
                {
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
