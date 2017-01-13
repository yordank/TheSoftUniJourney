using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ');
            var dict = new Dictionary<string, int>();

            foreach (var t in str)
            {

                dict[t.ToLower()] = 0;
            }


            foreach (var t in str)
            {

                dict[t.ToLower()]++;
            }

            List<string> output = new List<string>();

            foreach (var t in dict.Keys)
            {
                if (dict[t.ToLower()] % 2 == 1)
                    output.Add(t.ToLower());

            }

            //output=output.Remove(output.LastIndexOf(','));

            Console.WriteLine(string.Join(", ",output));

        }
    }
}
