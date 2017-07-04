using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
    public class Children
    {
        public Children(string name, string birthdate)
        {
            this.ChildrenName = name;

            this.BirthDate = birthdate;

        }
        public string ChildrenName { get; set; }
        public string BirthDate { get; set; }

        public override string ToString()
        {
            return $"{this.ChildrenName} {this.BirthDate}";
        }
    }
}
