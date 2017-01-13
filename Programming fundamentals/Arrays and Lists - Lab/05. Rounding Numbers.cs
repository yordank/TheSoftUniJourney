using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double [] array = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var t in array)
            {
                if(t<0)
                Console.WriteLine($"{t} => {(int)(t-0.5)}");
                else
                Console.WriteLine($"{t} => {(int)(t+0.5)}");
            }
             

        }
    }
}
