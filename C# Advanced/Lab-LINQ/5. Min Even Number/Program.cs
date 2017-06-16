using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Min_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            if (nums.Where(x => x % 2 == 0).Count() > 0)
                Console.WriteLine($"{nums.Where(x => x % 2 == 0).Min():f2}");
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
