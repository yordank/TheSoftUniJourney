using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printSign(n);
        }

        static void printSign(int number)
        {
            if (number > 0)
                Console.WriteLine($"The number {number} is positive.");

            if (number < 0)
                Console.WriteLine($"The number {number} is negative.");

            if (number == 0)
                Console.WriteLine($"The number {number} is zero.");
        }


    }
}
