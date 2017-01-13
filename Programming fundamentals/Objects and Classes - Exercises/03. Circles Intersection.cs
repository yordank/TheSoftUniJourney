using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Intersection_of_Circles
{
    class Circle
    {
        public Point Center { get; set; }
        public int Raduis{ get; set; }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Circle1Params = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var Circle2Params = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circle1 = new Circle { Center = new Point { X = Circle1Params[0], Y = Circle1Params[1] }, Raduis = Circle1Params[2] };
            Circle circle2 = new Circle { Center = new Point { X = Circle2Params[0], Y = Circle2Params[1] }, Raduis = Circle2Params[2] };

            if (Intersect(circle1, circle2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");


        }
        static bool Intersect(Circle circle1,Circle circle2)
        {
            decimal distance = (decimal)Math.Sqrt(Math.Pow(circle1.Center.X - circle2.Center.X, 2) + Math.Pow(circle1.Center.Y - circle2.Center.Y, 2));
            if (distance > circle1.Raduis + circle2.Raduis)
                return false;
            else
                return true;
        }

    }
}
