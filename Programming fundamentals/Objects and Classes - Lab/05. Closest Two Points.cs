using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Closest_Two_Points
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
            int n = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>(n);
            
            for (int i = 0; i < n; i++)
            {
                points.Add(readPointcoordinates());
            }

            decimal closestPointsDistance = decimal.MaxValue;

            int Point1Index = 0;
            int Point2Index = 0;

            for (int i = 0; i <n ; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    decimal PointsDistance = distance(points[i], points[j]);
                    if (closestPointsDistance > PointsDistance)
                    {
                        closestPointsDistance = PointsDistance;
                        Point1Index = i;
                        Point2Index = j;
                    }

                }
            }
            Console.WriteLine($"{closestPointsDistance:f3}");
            PointPrint(points[Point1Index]);
            PointPrint(points[Point2Index]);

        }

        static Point readPointcoordinates()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = input[0];
            int y = input[1];
            return new Point { X = x, Y = y };
        }

        static decimal distance(Point a, Point b)
        {
            decimal result = (decimal)Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));

            return result;
        }
        static void PointPrint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }
    }
}
