using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = RaiseToPower(number, power);
            Console.WriteLine(result);

        }

        static double RaiseToPower(double number,double power)
        {
            double result = 1;
            result = Math.Pow(number, power);
            return result;

        }

    }
}
