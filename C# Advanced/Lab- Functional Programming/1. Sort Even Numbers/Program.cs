using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ",
                Console.ReadLine().Split(',').Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x).ToList()));

        }
    }
}
