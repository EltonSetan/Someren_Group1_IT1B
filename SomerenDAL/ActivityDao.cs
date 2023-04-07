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
            conn.Open();
            SqlCommand command = new SqlCommand(
            "INSERT INTO Activity (Id, Name, Date, EndTime ) " +
            "VALUES (@ActivityId, @ActivityName, @Date, @EndTime); " +
           "SELECT SCOPE_IDENTITY();",
            conn);

            command.Parameters.AddWithValue("@ActivityId", activity.Id);
            command.Parameters.AddWithValue("@ActivityName", activity.Name);
            command.Parameters.AddWithValue("@Date", activity.Date);
            command.Parameters.AddWithValue("@EndTime)", activity.EndTime);
            
            conn.Close();
        }
        public void Update(Activities activity)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(
            "UPDATE Activity SET Id = @ActivityId, Name = @ActivityName, Date = @Date, EndTime = @EndTime" +
            "WHERE Id = @ActivityActivity",
            conn);
            command.Parameters.AddWithValue("@ActivityId", activity.Id);
            command.Parameters.AddWithValue("@ActivityName", activity.Name);
            command.Parameters.AddWithValue("@Date", activity.Date);
            command.Parameters.AddWithValue("@EndTime)", activity.EndTime);

            int nrOfRowsAffected = command.ExecuteNonQuery();
            conn.Close();
            // TODO: nrOfRowsAffected... (throw exception, or return boolean, ...)
        }
        public void Delete(Activities activity)
        {
            conn.Open();
            SqlCommand command = new SqlCommand(
            "DELETE FROM Activity WHERE Id = @Activity",
            conn);
            command.Parameters.AddWithValue("@Activity", activity.Id);

            int nrOfRowsAffected = command.ExecuteNonQuery();
            conn.Close();
            // TODO: nrOfRowsAffected... (throw exception, or return boolean, ...)
        }
    }
}


