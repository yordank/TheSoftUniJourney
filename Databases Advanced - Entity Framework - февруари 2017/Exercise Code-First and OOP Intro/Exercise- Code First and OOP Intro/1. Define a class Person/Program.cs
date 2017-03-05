using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Define_a_class_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Pesho";
            person1.Age = 20;

            Person person2 = new Person()
            {
                Name = "Gosho",
                Age = 18

            };

            Person person3 = new Person("Stamat", 43);


            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.WriteLine(person3);

        }
    }
}
