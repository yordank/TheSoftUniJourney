using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            var input = Console.ReadLine();

            while (input != "Party!")
            {
                var command = input.Split()[0];

                var criteria = input.Split()[1];
                
                if (command == "Remove")
                {
                    if (criteria == "StartsWith")
                    {
                        names.RemoveAll(elem=>names.Where(x => x.StartsWith(input.Split()[2])).ToList().Contains(elem));

                    }
                    if (criteria == "Length")
                    {
                        names.RemoveAll(elem => names.Where(x=>x.Length==int.Parse(input.Split()[2])).Contains(elem));

                    }

                    if (criteria == "EndsWith")
                    {
                        names.RemoveAll(elem => names.Where(x => x.EndsWith(input.Split()[2])).ToList().Contains(elem));

                    }

                }
                if (command == "Double")
                {
                    if (criteria == "StartsWith")
                    {
                        names.AddRange(names.Where(x => x.StartsWith(input.Split()[2])).ToList());

                    }
                    if (criteria == "Length")
                    {
                        names.AddRange(names.Where(x => x.Length==int.Parse(input.Split()[2])).ToList());

                    }

                    if (criteria == "EndsWith")
                    {
                        names.AddRange(names.Where(x => x.EndsWith(input.Split()[2])).ToList());

                    }

                }
                input = Console.ReadLine();
            }
            if (names.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
                return;
            }
            Console.WriteLine($"{string.Join(", ",names)} are going to the party!");

        }
    }
}
