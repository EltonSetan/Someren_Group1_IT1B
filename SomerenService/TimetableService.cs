using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;


namespace SomerenService
{
    public class TimetableService
    {
        private TimetableDao timetabledb;

        public TimetableService()
        {
            timetabledb = new TimetableDao();
        }

        public List<TimetableActivity> GetTimetableActivities(DateTime date)
        {
            return timetabledb.GetTimetableActivities(date);
        }

        public List<Teacher> GetSupervisors(int activityId)
        {
            return timetabledb.GetSupervisors(activityId);
        }

        
    }
}
