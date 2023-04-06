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

        public List<Participants> GetParticipantsById(Activity activity)
        {
            List<Participants> participants = participantsdb.GetParticipantsById(activity.Id);
            return participants;
        }
    }
}
