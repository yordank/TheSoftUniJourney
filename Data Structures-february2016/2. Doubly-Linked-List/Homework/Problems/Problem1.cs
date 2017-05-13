using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Problems
{
    public class Problem1
    {
        public static void solution()
        {
            List<int> listOfIntegers = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine($"Sum={listOfIntegers.Sum()}; Average={listOfIntegers.Average()}");

        }

    }
}
