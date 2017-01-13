using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int SumOfDigits = 0;
            int counter = 0;
            bool sumofdigits_is_5_7_11 = false;

            for (int i = 1; i <= number; i++)
            {
                counter = i;
                while (i > 0)
                {
                    SumOfDigits += i % 10;
                    i = i / 10;
                }
                sumofdigits_is_5_7_11 = (SumOfDigits == 5) || (SumOfDigits == 7) || (SumOfDigits == 11);
                Console.WriteLine($"{counter} -> {sumofdigits_is_5_7_11}");
                SumOfDigits = 0;
                i = counter;
            }

        }
    }
}
