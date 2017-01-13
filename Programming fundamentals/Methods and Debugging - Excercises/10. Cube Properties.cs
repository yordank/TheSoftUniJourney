using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            Console.WriteLine($"{cubepProperties(n, choice):F2}");
        }

        static double cubepProperties(double side, string choice)
        {
            if (choice == "face")
                return Math.Sqrt(2 * side * side);

            if (choice == "space")
                return Math.Sqrt(3 * side * side);

            if (choice == "volume")
                return  Math.Pow( side,3);

            if (choice == "area")
                return 6 * side * side;

            return 1;
        }
    }
}
