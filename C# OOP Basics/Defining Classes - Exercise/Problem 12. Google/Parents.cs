using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
    public class Parent
    {
        public Parent(string name,string birthdate)
        {
            this.ParentName = name;

            this.BirthDate =birthdate;

        }
        public string ParentName { get; set; }
        public string BirthDate { get; set; }

        public override string ToString()
        {
            return $"{this.ParentName} {this.BirthDate}";
        }
    }
}
