using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> tickets = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input!="PARTY")
            {
                tickets.Add(input);

                input = Console.ReadLine();

            }

            while (input != "END")
            {

                tickets.Remove(input);

                input = Console.ReadLine();


            }

            Console.WriteLine(tickets.Count());

            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket);
            }

        }
    }
}
