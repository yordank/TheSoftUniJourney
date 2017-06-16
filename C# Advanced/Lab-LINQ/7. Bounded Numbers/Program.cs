using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Bounded_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var bounds = Console.ReadLine().Split().Select(int.Parse).OrderBy(x=>x).ToList();

            var nums = Console.ReadLine().Split().Select(int.Parse);

            Console.WriteLine(string.Join(" ",nums.Where(x=>x>=bounds[0] && x <= bounds[1])));

        }
    }
}
