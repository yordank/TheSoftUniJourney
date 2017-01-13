using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long startNum = long.Parse(Console.ReadLine());
            long EndNum = long.Parse(Console.ReadLine());

            List<long> list = FindPrimesInRange(startNum, EndNum);

            if (list.Count != 0)
                Console.WriteLine(string.Join(", ", list));
            else
                Console.WriteLine("(empty list)");

        }
        static List<long> FindPrimesInRange(long startNum,long endNum)
        {

            List<long> list = new List<long>();

            for (long i = startNum; i <= endNum; i++)
                if (isPrime(i) == true)
                    list.Add(i);

            return list;

        }
        static bool isPrime(long n)
        {
            if (n < 2) return false;

            for (long i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0) return false;
            return true;
        }

    }
}
