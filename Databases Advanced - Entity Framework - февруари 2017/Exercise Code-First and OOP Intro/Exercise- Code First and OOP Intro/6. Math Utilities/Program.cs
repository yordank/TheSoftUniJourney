using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Utilities
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputArgs = Console.ReadLine().Split();

            while(inputArgs[0]!="End")
            {
                decimal num1 = decimal.Parse(inputArgs[1]);
                decimal num2 = decimal.Parse(inputArgs[2]);

                switch (inputArgs[0])
                {
                    case "Sum": Console.WriteLine($"{MathUtil.Sum(num1, num2):F2}");break;
                    case "Subtract": Console.WriteLine($"{MathUtil.Subtract(num1, num2):F2}"); break;
                    case "Multiply": Console.WriteLine($"{MathUtil.Multiply(num1, num2):F2}"); break;
                    case "Percentage":Console.WriteLine($"{MathUtil.Percentage(num1, num2):F2}"); break;
                    case "Divide": Console.WriteLine($"{MathUtil.Divide(num1, num2):F2}"); break;

                }

                inputArgs = Console.ReadLine().Split();

            }
        }
    }
}
