using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class SupervisorService
    {
        private SupervisorDao supervisordb;

        public SupervisorService()
        {
            supervisordb = new SupervisorDao();
        }
        public List<Teacher> GetAllSupervisors()
        {
            return supervisordb.GetAllSupervisors();
        }


        public List<Teacher> GetSupervisorsForActivity(int activityId)
        {
            return supervisordb.GetSupervisorsForActivity(activityId);
        }

        public List<Teacher> GetNonSupervisorsForActivity(int activityId)
        {
            return supervisordb.GetNonSupervisorsForActivity(activityId);
        }

        public void AddSupervisorToActivity(int activityId, int lecturerId)
        {
            supervisordb.AddSupervisorToActivity(activityId, lecturerId);
        }

        public void RemoveSupervisorFromActivity(int activityId, int lecturerId)
        {
            supervisordb.RemoveSupervisorFromActivity(activityId, lecturerId);
        }
    }
}
