using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(decimal.Parse);

            SortedDictionary<decimal, int> dict = new SortedDictionary<decimal, int>();
            

            foreach (var t in input)
            {
                if (!dict.ContainsKey(t) )
                    dict.Add(t, 1);
                else
                    dict[t]++;
            }
             

            foreach (var t in dict)
            {
                Console.WriteLine("{0} -> {1}", t.Key, t.Value);
            }

        }
    }
}
