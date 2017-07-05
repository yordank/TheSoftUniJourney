using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    public class Person
    {
        public Person(string firstName,string lastName,int age,double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;

        }

        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        public int Age { get { return age; } }
        public string FirstName { get { return this.firstName; } }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} get {this.salary:f2} leva";
        }

    public void IncreaseSalary(double percent)
    {
        if(this.age>30)
        {
            this.salary += this.salary * percent / 100;
        }
        else
        {
            this.salary += this.salary * percent / 200;
        }
    }

    }
 
