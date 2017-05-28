using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Dictionary<string, string> dict = new Dictionary<string, string>();

            while (input != "search")
            {

                string Name = input.Split('-')[0];

                string phoneNumber = input.Split('-')[1];

                if (!dict.ContainsKey(Name))
                    dict.Add(Name, phoneNumber);

                else
                {
                    dict[Name] = phoneNumber;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "stop")
            {
                if (dict.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {dict[input]}");
                }

                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }

                input = Console.ReadLine();
            }


        }
    }
}