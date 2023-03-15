using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;
using System.Xml.Linq;

namespace SomerenDAL
{
    public class RoomsDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT RoomId, Building, Floor, RoomType, NrOfBeds, RoomNr FROM [Room]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }



        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> Rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room Room = new Room()
                {
                    RoomId = (int)dr["RoomId"],
                    Building = dr["Building"].ToString(),
                    Floor = (int)dr["Floor"],
                    RoomType = dr["RoomType"].ToString(),
                    NrOfBeds = (int)dr["NrOfBeds"],
                    RoomNr = (int)dr["RoomNr"]
                };
                Rooms.Add(Room);
            }
            return Rooms;
        }

    }
}