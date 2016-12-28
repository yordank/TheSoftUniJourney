using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());

            decimal distance = speed * time1;
            speed *= (decimal) 1.1;
            distance += speed * time2;
            speed *= (decimal)0.95;
            distance += speed * time3;
            distance /= 60;
            Console.WriteLine($"{distance:f2}");

        }
    }
}
