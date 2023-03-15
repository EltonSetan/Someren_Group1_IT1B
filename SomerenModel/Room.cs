namespace SomerenModel
{
    public class Room
    {
        public int RoomId { get; set; }         // database id
        public string Building { get; set; }         // building 1 or 2
        public int Floor { get; set; }         // floor 1 or 2
        public string RoomType { get; set; }      // student or teacher
        public int NrOfBeds { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public int RoomNr { get; set; }     // RoomNumber, e.g. 206
    }
}