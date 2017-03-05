using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Utilities
{
    class MathUtil
    {
        public static decimal	Sum(decimal num1,decimal num2)
        {
            return num1 + num2;
        }
        public static decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        public static decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public static decimal Divide(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        public static decimal Percentage(decimal num1, decimal num2)
        {
            return num1 * num2/100;
        }





    }
}
