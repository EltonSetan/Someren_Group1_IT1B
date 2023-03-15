﻿using System;

namespace SomerenModel
{
    public class Student
    {
        public int Id { get; set; }     // database id
        public string Name { get; set; }
        public int Number { get; set; } // StudentNumber, e.g. 474791
       // public DateTime BirthDate { get; set; }

        public string LastName { get; set; }
        public int TelephoneNumber { get; set; }
        public int StudentNumber { get; set; }
        public int RoomId { get; set; }
        public int DrinkId { get; set; }

        public string Class { get; set; }
    }
}