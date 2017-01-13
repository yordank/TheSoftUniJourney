using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * weight + 2 * height);
            Console.WriteLine(weight* height);
            Console.WriteLine(Math.Sqrt((double)(weight * weight + height * height)));

        }
    }
}
