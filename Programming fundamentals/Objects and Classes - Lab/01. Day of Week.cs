using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
            DateTime date = new DateTime(input[2], input[1], input[0]);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
