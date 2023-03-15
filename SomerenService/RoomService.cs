using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class RoomService
    {
        private RoomsDao roomdb;

        public RoomService()
        {
            roomdb = new RoomsDao();
        }

        public List<Room> GetRooms()
        {
            List<Room> students = roomdb.GetAllRooms();
            return students;
        }
    }
}