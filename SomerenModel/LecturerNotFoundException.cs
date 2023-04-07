using System;

namespace SomerenModel
{
    public class LecturerNotFoundException : Exception
    {
        public LecturerNotFoundException()
        {
        }

        public LecturerNotFoundException(string message)
            : base(message)
        {
        }

        public LecturerNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
