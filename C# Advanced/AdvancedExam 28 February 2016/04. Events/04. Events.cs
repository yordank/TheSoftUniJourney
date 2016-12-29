using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Events
{
    class Person
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<string> hours { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = Regex.Match(input, "#([a-zA-Z]{1,}):\\s*@([a-zA-Z]{1,})\\s*([0-2]?[0-9]):([0-5]?[0-9])");

                if (match.Success)
                {
                    int hour = int.Parse(match.Groups[3].Value);

                    if (hour > 23 || hour < 0)
                        continue;

                    Person person = new Person();
                    person.Name = match.Groups[1].Value;
                    person.Location = match.Groups[2].Value;
                    person.hours = new List<string>();
                    person.hours.Add(match.Groups[3].Value + ":" + match.Groups[4].Value);

                    if (people.Where(x => x.Name == person.Name && x.Location == person.Location).Count() > 0)
                    {
                        var p = people.Where(x => x.Name == person.Name && x.Location == person.Location).First();

                        p.hours.Add(match.Groups[3].Value + ":" + match.Groups[4].Value);

                        people.Where(x => x.Name == person.Name && x.Location == person.Location).Single().hours = p.hours;

                    }

                    else
                    {
                        people.Add(person);
                    }

                  

                }
            }

            var cities = Console.ReadLine().Split(',').ToList().OrderBy(x=>x);

            foreach (var city in cities)
            {
                int i = 1;

                if(people.Where(x => x.Location == city).OrderBy(x => x.Name).Count()>0)
                Console.WriteLine($"{city}:");

                foreach (var pers in people.Where(x=>x.Location==city).OrderBy(x=>x.Name))
                {
                    Console.WriteLine($"{i}. {pers.Name} -> {string.Join(", ",pers.hours.OrderBy(x=>x))}");
                    i++;
                }
            }


        }
    }
}
