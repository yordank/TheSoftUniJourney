using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date=DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            double steps = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            Console.WriteLine($"Time Arrival: {date.AddSeconds(steps*seconds%86400).ToString("HH:mm:ss")}");

        }
    }
}
