using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person person = new Person(input[0], int.Parse(input[1]));

                family.AddMember(person);


            }
            Console.WriteLine("----------------");
            Console.WriteLine($"oldest person:{family.getOldestPerson()}");


        }
    }
}
