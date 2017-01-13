using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensandOdds(Math.Abs(n)));
        }
        private static int GetMultipleOfEvensandOdds(int n)
        {
            int Evens = GetSumOfEvenDigits(n);
            int Odds = GetSumOfOddDigits(n);
            return Evens * Odds;
        }

        private static int GetSumOfOddDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                    sum += lastDigit;
                n /= 10;
            }

            return sum;
        }

        private static int GetSumOfEvenDigits(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                    sum += lastDigit;
                n /= 10;
            }

            return sum;
        }



    }
}
