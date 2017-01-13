using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> array = Console.ReadLine().Split().Select(decimal.Parse).ToList();
            array.Sort();
            
            Console.WriteLine(string.Join(" <= ",array));
        }
    }
}
