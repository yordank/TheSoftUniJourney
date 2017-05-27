using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();

            foreach (var num in input)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }


            }

            foreach (var dictElem in dict)
            {
                Console.WriteLine($"{dictElem.Key} - {dictElem.Value} times");
            }

        }

    }
}
