using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input;

        List<Person> people = new List<Person>();

        while((input=Console.ReadLine())!="END")
        {
            var args = input.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            Person person = new Person(args[0], int.Parse(args[1]), args[2]);

            people.Add(person);
        }

        int n = int.Parse(Console.ReadLine());

        Person p = people[n-1];

        int count = 0;

        foreach (var person in people)
        {
            if (p.CompareTo(person) == 0)
                count++;            
        }

        if(count==1)
        {
            Console.WriteLine("No matches");
        }

        else
        {
            Console.WriteLine($"{count} {people.Count-count} {people.Count}");
        }


    }
}

