using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Reverse_and_exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).Reverse().ToList();

            var num = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ",nums.Where(x=>x%num!=0)));

        }
    }
}
