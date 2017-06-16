
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Custom_Min_Function
{
    class Program
    {
        static void Main()
        {
            Func<List<int>,int> minFunc = x=>x.Min();

            Console.WriteLine(minFunc(
                    Console.ReadLine().Split(' ').Select(int.Parse).ToList())
                );

        }

        


        
    }
}
