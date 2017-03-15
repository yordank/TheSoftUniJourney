using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Code_First_Student_System.Models
{
    public class Licence
    {
        public int Id { get; set; }
        public string  Name { get; set; } 

        public Resource Resource { get; set; }
    }
}
