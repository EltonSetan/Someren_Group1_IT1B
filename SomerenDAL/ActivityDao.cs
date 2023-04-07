using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System;
using System.Data.Common;
using System.Diagnostics;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activities> GetAllActivities()
        {
            string query = "SELECT ActivityId, ActivityName, Date, EndTime FROM [Activity]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activities> ReadTables(DataTable dataTable)
        {
            List<Activities> activities = new List<Activities>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activities activity = new Activities()
                {
                    Id = (int)dr["ActivityId"],
                    Name = dr["ActivityName"].ToString(),
                    Date = dr["Date"].ToString(),
                    //StartTime = (DateTime)dr["StartTime"],
                    EndTime = (DateTime)dr["EndTime"],

                };
                activities.Add(activity);
            }
            return activities;
        }

        public void Add(Activities activity)
        {
            string query = "INSERT INTO Activity (ActivityId, ActivityName, Date, EndTime) VALUES (@ActivityId, @ActivityName, @Date, @EndTime)";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activity.Id),
                new SqlParameter("@ActivityName", activity.Name),
                new SqlParameter("@Date", activity.Date),
                new SqlParameter("@EndTime", activity.EndTime)
            };

           ExecuteEditQuery(query, sqlParameters);
        }
        public void Update(Activities activity)
        {
            string query = "UPDATE Activity SET ActivityId = @ActivityId, ActivityName = @ActivityName, Date = @Date, EndTime = @EndTime WHERE ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activity.Id),
                new SqlParameter("@ActivityName", activity.Name),
                new SqlParameter("@Date", activity.Date),
                new SqlParameter("@EndTime", activity.EndTime)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
        public void Delete(Activities activity)
        {
            string query = "DELETE FROM Activity WHERE ActivityId = @ActivityId";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ActivityId", activity.Id)
            };

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}


