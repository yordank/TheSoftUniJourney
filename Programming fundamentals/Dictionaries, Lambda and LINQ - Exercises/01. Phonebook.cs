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
            var input = Console.ReadLine().Split(' ');
            Dictionary<string, string> dict = new Dictionary<string, string>();
            List<string> output = new List<string>();

            while (input[0] != "END")
            {
               
                
                if (input[0] == "A")
                {
                    if (!dict.ContainsKey(input[1]))
                        dict.Add(input[1], input[2]);
                    else
                        dict[input[1]] = input[2];
                }


                if (input[0] == "S")
                {
                    if (!dict.ContainsKey(input[1]))
                        output.Add($"Contact {input[1]} does not exist.");
                    else
                        output.Add($"{input[1]} -> {dict[input[1]]}");

                }

                input = Console.ReadLine().Split(' ');

            }
            foreach(var t in output)
            Console.WriteLine(t);
        }
    }
}
