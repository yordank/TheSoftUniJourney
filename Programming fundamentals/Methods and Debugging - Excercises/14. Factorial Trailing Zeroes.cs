using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial = factorial * i;
            Console.WriteLine(func(factorial));
        }
        static BigInteger func(BigInteger n)
        {
            int count = 0;
            int currentCount = 0;
            while (n > 0)
            {
                if (n % 10 == 0) currentCount++;
                if (n % 10 != 0) currentCount = 0 ;
                if (currentCount > count) count = currentCount;
                n = n / 10;
            }
            return count;
        }
    }
}
