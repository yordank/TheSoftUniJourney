using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedSet<string> sortedSet = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {

                var input = Console.ReadLine().Split();

                foreach (var elem in input)
                {
                    sortedSet.Add(elem);
                }




            }

            Console.WriteLine($"{string.Join(" ",sortedSet)}");

        }
    }
}
