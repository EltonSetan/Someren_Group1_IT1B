namespace SomerenModel
{
    public class Teacher
    {
        public int Id { get; set; }     // database id
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; } // LecturerNumber, e.g. 47198

        public int Age { get; set; }

        public int TelephoneNumber { get; set; }

        public int RoomId { get; set; }
        public int DrinkId { get; set; }
        public string isSupervisor { get; set; }
    }
}