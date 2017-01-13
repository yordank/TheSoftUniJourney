using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Rectangle_Position
{
    class Rectangle
    {
        public int left { get; set; }
        public int top { get; set; }
        public int wight { get; set; }
        public int height { get; set ; }
        public int right { get; set ; }
        public int bottom { get; set ; }




    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstRectCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondRectCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rect1 = readRectangle(firstRectCoord[0], firstRectCoord[1], firstRectCoord[2], firstRectCoord[3]);
            Rectangle rect2 = readRectangle(secondRectCoord[0], secondRectCoord[1], secondRectCoord[2], secondRectCoord[3]);

            if (isFirstRectInSecondRect(rect1, rect2))
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Not Inside");

        }
        static bool isFirstRectInSecondRect(Rectangle rect1,Rectangle rect2)
        {
            if (rect1.left>=rect2.left && rect1.right<=rect2.right && rect1.top <=rect2.top && rect1.bottom>=rect2.bottom)
                return true;
            else
                return false;
        }

        static Rectangle readRectangle(int leftCoordinate, int topCoordinate, int wightDistance, int heightDistance)
        {
            return new Rectangle
            {
                left = leftCoordinate,
                top = topCoordinate,
                wight = wightDistance,
                height = heightDistance,
                right = leftCoordinate + wightDistance,
                bottom=topCoordinate-heightDistance
            };

            
        } 
    }
}
