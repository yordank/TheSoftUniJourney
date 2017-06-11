using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Non_Digit_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex("[^0-9]");

            int count = regex.Matches(input).Count;

            Console.WriteLine($"Non-digits: {count}");

        }
    }
}
