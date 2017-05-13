using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Problems
{
    public class Problem2
    {
        public static void solution()
        {
            List<string> listOfStrings = Console.ReadLine().Split().ToList();
            listOfStrings.Sort(compareFunction);
            Console.WriteLine($"{string.Join("\n", listOfStrings)}");
        }

        private static int compareFunction(string x, string y)
        {
            return string.Compare(x, y);
        }

    }
}
