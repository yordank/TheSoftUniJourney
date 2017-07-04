using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rectangle_Intersection
{
    public class Rectangle
    {
        public string Id { get; set; }

        public decimal width { get; set; }

        public decimal height { get; set; }

        public decimal topLeftX { get; set; }

        public decimal topLeftY { get; set; }

        public string intersect(Rectangle other)
        {
            if((topLeftX>=other.topLeftX && topLeftX <= other.topLeftX+other.width) || (topLeftX+height >= other.topLeftX && topLeftX+height <= other.topLeftX + other.width))
            {
                if((topLeftY >= other.topLeftY && topLeftY <= other.topLeftY + other.height) || (topLeftY+height >= other.topLeftY && topLeftY <= other.topLeftY + other.height))
                {
                    return "true";
                }
            }

            return "false";


        }
    }
}
