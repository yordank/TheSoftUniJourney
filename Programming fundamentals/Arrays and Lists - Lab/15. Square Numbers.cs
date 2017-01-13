using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ListArray = Console.ReadLine().Split().Select(int.Parse).Where(x=>Math.Sqrt(x)==(int)Math.Sqrt(x)).ToList();
            ListArray.Sort((a,b)=>b.CompareTo(a));

            Console.WriteLine(string.Join(" ",ListArray));

        }
    }
}
