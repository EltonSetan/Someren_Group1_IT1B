using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activities
    {
        public int Id { get; set; }     // database id
        public string Name { get; set; }
        //public string Date { get; set; }
        public string Date { get; set; }
        public DateTime EndTime { get; set; }
    }
}
