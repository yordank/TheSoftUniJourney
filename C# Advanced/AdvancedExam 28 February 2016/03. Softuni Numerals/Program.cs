using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.Softuni_Numerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger num = convertStringToNum(input);

            Console.WriteLine(FromBase(num, 5));

        }

        private static BigInteger convertStringToNum(string input)
        {
           
            input = input.Replace("aba", "1");
            input = input.Replace("bcc", "2");
            input = input.Replace("cdc", "4");
            input = input.Replace("aa", "0");
            input = input.Replace("cc", "3");

            return BigInteger.Parse(input);
        }

        public static BigInteger FromBase(BigInteger value, int @base)
        {
            string number = value.ToString();
            BigInteger n = 1;
            BigInteger r = 0;

            for (int i = number.Length - 1; i >= 0; --i)
            {
                r += n * (number[i] - '0');
                n *= @base;
            }

            return r;
        }

    }

}
