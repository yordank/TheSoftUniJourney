using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sum_and_Average
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine($"Sum={input.Sum()}; Average={input.Average():f2}");
             

        }
    }
}
