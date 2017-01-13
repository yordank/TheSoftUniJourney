using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                if (isPalindrom(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                    Console.WriteLine(i);
            
        }
        static bool isPalindrom(int n)
        {
            int number = n;
            int reverseNumber = 0;
            int Digit = 0;
            while (number > 0)
            {
               
                Digit=number % 10;
                reverseNumber = 10 * reverseNumber + Digit;
                number = number / 10;
                
            }

            if(reverseNumber==n)
            return true;
            else
            return false;
        }
        static bool SumOfDigits(int num)
        {
            int sum = 0;
             
            int Digit = 0;
            while (num > 0)
            {

                Digit = num % 10;
                sum += Digit;
                num = num / 10;

            }
            if (sum % 7 == 0)
                return true;
            else
                return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            int number = num;
            
            int Digit = 0;
            while (number > 0)
            {

                Digit = number % 10;
                number = number / 10;
                if (Digit % 2 == 0) return true;
            }
            return false;
        }

    }
}
