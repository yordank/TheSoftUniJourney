using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

           
                if (isPrime(n) == true)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");

        }
        static bool isPrime(long n)
        {
            if (n < 2) return false;

            for (int i = 2; i <=Math.Sqrt( n); i++)
                if (n % i == 0) return false;
            return true;
        }
    }
}
