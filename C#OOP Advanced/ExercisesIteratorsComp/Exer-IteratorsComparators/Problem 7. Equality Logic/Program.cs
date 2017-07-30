using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        SortedSet<Person> sortedSetPeople = new SortedSet<Person>();

        HashSet<Person> people = new HashSet<Person>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();

            var args = input.Split();

            Person person = new Person(args[0], int.Parse(args[1]));

            people.Add(person);

            sortedSetPeople.Add(person);
        }

        Console.WriteLine(people.Count);

        Console.WriteLine(sortedSetPeople.Count);

    }
}

