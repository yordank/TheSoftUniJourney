using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_a_Class_Person
{
    class Person
    {

        public string name;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);

            //Person person1 = new Person()
            // {
            //    name ="pesho",
            //    age =31
            // };

            //Person person2 = new Person();

            //person2.name = "gosho";
            //person2.age = 30;

            //var listPersons = new List<Person>();
            //listPersons.Add(person1);
            //listPersons.Add(person2);

            //listPersons.OrderBy(x=>x.name).ToList().ForEach(x => Console.WriteLine(x.name + " " + x.age));


        }

    }
}
