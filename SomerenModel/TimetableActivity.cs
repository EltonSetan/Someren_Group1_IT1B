using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class TimetableActivity
    {
        public string NameOfActivity { get; set; }
        public List<Teacher> Supervisors { get; set; }
        public DateTime TimeOfActivity { get; set; }
        public int activityId { get; set; }
    }
}
