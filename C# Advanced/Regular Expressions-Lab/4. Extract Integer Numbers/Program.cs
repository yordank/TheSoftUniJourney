using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\d+");

            var matches = regex.Matches(input);

            foreach (var num in matches)
            {
                Console.WriteLine(num);
            }
        }
    }
}
