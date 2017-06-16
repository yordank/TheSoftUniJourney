using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            nums.Sort((x, y) => Comp(x, y));

            Console.WriteLine(string.Join(" ",nums));
        }

        private static int Comp(int i, int j)
        {
            if (i % 2 == 0 && j % 2 != 0)
            {
                return -1;
            }

            if (i % 2 != 0 && j % 2 == 0)
            {
                return 1;
            }

            return i.CompareTo(j);


        }
    }
}
