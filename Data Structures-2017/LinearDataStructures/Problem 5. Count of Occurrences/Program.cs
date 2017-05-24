using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Count_of_Occurrences
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < input.Count(); i++)
            {
                if(!dict.ContainsKey(input[i]))
                {
                    dict.Add(input[i], 1);
                }

                else
                {
                    dict[input[i]]++;
                }


            }

            foreach (var elem in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{elem.Key} -> {elem.Value} times");
            }

        }
    }
}
