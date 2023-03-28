using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class ActivitySupervisorService
    {
        ActivitySupervisorDao activitySupervisorDao;

        public ActivitySupervisorService()
        {
            activitySupervisorDao = new ActivitySupervisorDao();
        }

        public void AddSupervisor(int lecturerId, int activityId)
        {
            activitySupervisorDao.AddSupervisor(lecturerId, activityId);
        }

        public void RemoveSupervisor(int lecturerId, int activityId)
        {
            activitySupervisorDao.RemoveSupervisor(lecturerId, activityId);
        }
    }
}
