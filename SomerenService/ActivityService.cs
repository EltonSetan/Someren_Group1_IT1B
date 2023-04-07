using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class ActivityService
    {
        private ActivityDao activitydb;

        public ActivityService()
        {
            activitydb = new ActivityDao();
        }

        public List<Activities> GetActivity()
        {
            List<Activities> activities = activitydb.GetAllActivities();
            return activities;
        }
        public void AddActivity(Activities activities)
        {
            activitydb.Add(activities);
        }
        public void UpdateActivity(Activities activities)
        {
            activitydb.Update(activities);
        }
        public void DeleteActivity(Activities activities)
        {
            activitydb.Delete(activities);
        }

    }
}