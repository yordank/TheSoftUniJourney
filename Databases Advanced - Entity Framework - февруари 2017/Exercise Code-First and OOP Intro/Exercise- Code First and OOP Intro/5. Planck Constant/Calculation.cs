using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Planck_Constant
{
    class Calculation
    {
        public static double planckConstant = 6.62606896e-34;
        public static double piConstant = 3.14159;

        public static double redicedPlankConstant()
        {
            return planckConstant / (2 * piConstant);
        }
    }
}
