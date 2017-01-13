using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_2.Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            int Base = int.Parse(input[0]);
            string Number = input[1];

            BigInteger sum = 0;
            for (int i = Number.Length - 1; i >= 0; i--)
            {
                BigInteger digit = Number[i] - '0';
               
                sum +=digit* pow(Base, Number.Length - i-1);
            }

            Console.WriteLine(sum);
        }
        static  BigInteger pow(BigInteger a, BigInteger b)
        {
            BigInteger sum = 1;

            for (int i = 1; i <= b; i++)
            {
                sum *= a ;
            }
            return sum;
        }
    }
}
