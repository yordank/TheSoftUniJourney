using System;


namespace CoordinatePoint
{
    class CoordinatePoint
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestPoints(x1, y1, x2, y2);
        }

        private static void PrintClosestPoints(double x1, double y1, double x2, double y2)
        {
            double DistanceFromPointToCenter1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double DistanceFromPointToCenter2 = Math.Sqrt(x2 * x2 + y2 * y2);

            if (DistanceFromPointToCenter1 < DistanceFromPointToCenter2)
                Console.WriteLine("({0}, {1})", x1, y1);
            else
                Console.WriteLine("({0}, {1})", x2, y2);
        }


    }
}