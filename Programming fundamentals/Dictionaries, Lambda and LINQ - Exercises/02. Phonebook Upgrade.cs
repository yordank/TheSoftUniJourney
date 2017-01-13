using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
            List<string> output = new List<string>();
            
            while (input[0] != "END")
            {


                if (input[0] == "A")
                {
                    if (!dict.ContainsKey(input[1]))
                    {
                        dict.Add(input[1], input[2]);
                        output.Add($"{input[1]} -> {dict[input[1]]}");
                    }
                    else
                    {
                        dict[input[1]] = input[2];
                        output.Add($"{input[1]} -> {dict[input[1]]}");
                    }
                }


                if (input[0] == "S")
                {
                    if (!dict.ContainsKey(input[1]))
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    else
                        Console.WriteLine($"{input[1]} -> {dict[input[1]]}");
                        

                }

                if (input[0] == "ListAll")
                {
                   // output.Sort();
                    foreach (var t in dict.Keys)
                        Console.WriteLine($"{t} -> {dict[t]}");
                }

                        input = Console.ReadLine().Split(' ');

            }
          //  foreach (var t in output)
           //     Console.WriteLine(t);
        }
    }
}
