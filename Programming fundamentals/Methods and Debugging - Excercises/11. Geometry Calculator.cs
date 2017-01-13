using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "circle":Console.WriteLine($"{circleArea(double.Parse(Console.ReadLine())):F2}");break;
                case "triangle": Console.WriteLine($"{triangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())):F2}"); break;
                case "square": Console.WriteLine($"{squareArea(double.Parse(Console.ReadLine())):F2}"); break;
                case "rectangle": Console.WriteLine($"{rectArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())):F2}"); break;


            }

        }

        static double circleArea(double r)
        {
            return Math.PI * r * r;
        }
        static double rectArea(double a, double b)
        {
            return a * b;
        }
        static double squareArea(double a)
        {
            return a * a;
        }
        static double triangleArea(double a, double b)
        {
            return a * b/2;
        }
    }
}
