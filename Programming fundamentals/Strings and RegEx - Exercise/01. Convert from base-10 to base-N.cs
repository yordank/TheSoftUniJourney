using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem01.Convert
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            BigInteger BaseOfNumber = BigInteger.Parse(input[0]);
            BigInteger Number = BigInteger.Parse(input[1]);


            string number = string.Empty;

            while (Number > 0)
            {
                number+= $"{Number % BaseOfNumber}";
                Number = Number / BaseOfNumber;
            }

            Console.WriteLine(string.Join("",number.ToCharArray().Reverse()));

        }
    }
}
