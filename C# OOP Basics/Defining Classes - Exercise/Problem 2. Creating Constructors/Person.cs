using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Creating_Constructors
{
    class Person
    {
        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }
        public Person(int age) : this()
        {
            this.age = age;
        }
        public Person(string name, int age) : this(age)
        {
            this.name = name;
        }

        public string name;
        public int age;
    }
}
