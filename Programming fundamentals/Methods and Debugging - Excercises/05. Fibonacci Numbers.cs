using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));

        }
        static int Fib(int n)
        {
            if (n == 0 || n == 1) return 1;
            int firstElem = 1;
            int seconfElem = 1;
            int sum = firstElem + seconfElem;

            for (int i = 2; i <= n; i++)
            {

                sum = firstElem + seconfElem;
                firstElem = seconfElem;
                seconfElem = sum;
            }
            return sum;

        }
    }
}
