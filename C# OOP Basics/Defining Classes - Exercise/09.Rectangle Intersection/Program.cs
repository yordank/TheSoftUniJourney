using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();

            int n = int.Parse(line[0]);

            int intersects = int.Parse(line[1]);

            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();
             

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine().Split();
                Rectangle rect = new Rectangle()
                {
                    Id = line[0],
                    width = decimal.Parse(line[1]),
                    height = decimal.Parse(line[2]),
                    topLeftX = decimal.Parse(line[3]),
                    topLeftY=decimal.Parse(line[4])

                };

                rectangles.Add(line[0],rect);
            }

            for (int i = 0; i < intersects; i++)
            {
                line = Console.ReadLine().Split();

                var rect1 = rectangles[line[0]];

                var rect2 = rectangles[line[1]];


                Console.WriteLine(rect1.intersect(rect2));

            }




        }
    }
}
