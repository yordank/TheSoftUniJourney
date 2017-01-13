using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_4.Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
           
            Console.WriteLine(method(input[0],input[1]));

        }
        static BigInteger method(string str1, string str2)
        {
            BigInteger sum = 0;

            for (int i = 0; i < Math.Min(str1.Length, str2.Length); i++)
            {
                sum += str2[i] * str1[i];
            }

            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str1.Length - str2.Length; i++)
                {
                    sum += str1[i+ Math.Min(str1.Length, str2.Length)];
                }
            }
            else
            {
                for (int i = 0; i < -str1.Length + str2.Length; i++)
                {
                    sum += str2[i+ Math.Min(str1.Length, str2.Length)];
                }
            }

            return sum;
        }
    }
}
