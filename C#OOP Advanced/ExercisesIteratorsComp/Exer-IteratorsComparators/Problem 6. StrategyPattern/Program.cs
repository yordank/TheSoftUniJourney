using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<Person> peopleName = new SortedSet<Person>(new ComparatorName());

        SortedSet<Person> peopleAge = new SortedSet<Person>(new ComparatorAge());


        for (int i = 0; i < n; i++)
        {
            var args = Console.ReadLine().Split();

            Person person = new Person(args[0], int.Parse(args[1]));

            peopleName.Add(person);

            peopleAge.Add(person);

        }

       

        foreach (var person in peopleName)
        {
            Console.WriteLine(person.ToString());
        }

        foreach (var person in peopleAge)
        {
            Console.WriteLine(person.ToString());
        }


    }
}

