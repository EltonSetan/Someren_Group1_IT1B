using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public  class LecturersService
    {
        private LecturersDao teacherdb;

        public LecturersService()
        {
            teacherdb = new LecturersDao();
        }

        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = teacherdb.GetAllTeachers();
            return teachers;
        }
    }
}
