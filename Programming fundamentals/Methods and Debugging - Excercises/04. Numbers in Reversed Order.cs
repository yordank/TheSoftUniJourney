using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(reversedNumber(number));
        }
        static string reversedNumber(string number)
        {
            var str = number.ToCharArray();
             Array.Reverse(str);
            return new string (str);
        }
    }
}
