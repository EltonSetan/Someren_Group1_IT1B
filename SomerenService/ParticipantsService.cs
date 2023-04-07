using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ParticipantsService
    {
        private ParticipantsDao participantsdb;

        public ParticipantsService()
        {
            participantsdb = new ParticipantsDao();
        }

        public List<Participants> GetParticipantsById(int ActivityId)
        {
           
            return participantsdb.GetParticipantsById(ActivityId);
        }

        public List<Participants> GetNonParticipantsById(int ActivityId)
        {

            return participantsdb.GetNonParticipantsById(ActivityId);
        }

        public void AddParticipants(int activityId, int studentId)
        {
            participantsdb.AddParticipants(activityId, studentId);
        }

        public void RemoveParticipants(int activityId, int studentId)
        {
            participantsdb.RemoveParticipants(activityId, studentId);
        }
    }
}
