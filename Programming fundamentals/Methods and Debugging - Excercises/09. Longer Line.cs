using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            if (lineDistance(x1, y1, x2, y2) >= lineDistance(x3, y3, x4, y4))
            {
                Console.WriteLine($"({string.Join(", ", Point(x1, y1, x2, y2, 1))})({string.Join(", ", Point(x1, y1, x2, y2, 2))})");
            }
           else
                Console.WriteLine($"({string.Join(", ", Point(x3, y3, x4, y4, 1))})({string.Join(", ", Point(x3, y3, x4, y4, 2))})");

        }

        static double lineDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }


        static List<double> Point(double x1, double y1, double x2, double y2,int choice)
        {
            double distance1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double distance2 = Math.Sqrt(x2 * x2 + y2 * y2);

            List<double> list = new List<double>();

            if (choice == 1)
            {
                if (distance1 > distance2)
                {
                    list.Add(x2);
                    list.Add(y2);
                }
                else
                {
                    list.Add(x1);
                    list.Add(y1);
                }
            }

            if (choice == 2)
            {
                if (distance1 <= distance2)
                {
                    list.Add(x2);
                    list.Add(y2);
                }
                else
                {
                    list.Add(x1);
                    list.Add(y1);
                }
            }
            return list;

        }


    }
}
