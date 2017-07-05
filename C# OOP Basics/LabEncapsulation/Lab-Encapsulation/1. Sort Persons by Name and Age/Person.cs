using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    public class Person
    {
        public Person(string firstName,string lastName,int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        private string firstName;
        private string lastName;
        private int age;

        public int Age { get { return age; } }
        public string FirstName { get { return this.firstName; } }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} is a {this.age} years old";
        }
    }
 
