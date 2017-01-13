using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Distance_Between_Points
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var Point1Coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Point2Coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point a = readPointcoordinates(Point1Coordinates[0], Point1Coordinates[1]);
            Point b = readPointcoordinates(Point2Coordinates[0], Point2Coordinates[1]);

            Console.WriteLine($"{distance(a,b):f3}");
        }
        static Point readPointcoordinates(int x,int y)
        {
            return new Point { X = x, Y = y };
        }

        static decimal distance(Point a, Point b)
        {
            decimal result =(decimal)Math.Sqrt( Math.Pow( a.X - b.X,2)+ Math.Pow(a.Y - b.Y, 2));

            return result;
        }
    }
}
