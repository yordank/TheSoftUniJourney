using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var average = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .Average();
            Console.WriteLine($"{average:f2}");

        }
    }
}
