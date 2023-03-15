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

        public List<Activity> GetActivity()
        {
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }
    }
}