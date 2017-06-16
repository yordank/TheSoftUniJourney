using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Take_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse);

            Console.WriteLine(string.Join(" ", nums.Distinct().Where(x => x >= 10 && x <= 20).Take(2)));


        }

    }
}
