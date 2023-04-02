using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;

namespace SomerenDAL
{
    public class TimetableDao : BaseDao
    {
        public List<TimetableActivity> GetTimetableActivities(DateTime dateOfActivity)
        {
            string query = "SELECT ActivityId, ActivityName, Date FROM [Activity] WHERE Date BETWEEN @date AND @dateEnd ORDER BY CAST(Date AS time) DESC";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
               new SqlParameter("@date", dateOfActivity.Date),
               new SqlParameter("@dateEnd", dateOfActivity.AddHours(23.59))
            };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<TimetableActivity> ReadTables(DataTable dataTable)
        {
            List<TimetableActivity> activities = new List<TimetableActivity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                TimetableActivity activity = new TimetableActivity()
                {
                    activityId = (int)dr["ActivityId"],
                    NameOfActivity = dr["ActivityName"].ToString(),
                    TimeOfActivity = (DateTime)dr["Date"]
                };
                activities.Add(activity);
            }
            return activities;
        }

        public List<Teacher> GetSupervisors(int activityId)
        {
            string query = "SELECT FirstName, LastName FROM Lecturer JOIN supervise ON Supervise.LecturerId = Lecturer.LecturerId JOIN Activity ON Supervise.ActivityId = Activity.ActivityId WHERE supervise.activityId = @activityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@activityId", activityId)
            };
            return ReadData(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadData(DataTable dataTable)
        {
            List<Teacher> supervisors = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher supervisor = new Teacher()
                {
                    Name = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString()
                };
                supervisors.Add(supervisor);
            }
            return supervisors;
        }
    }
}


