using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            decimal floorWidth = decimal.Parse(Console.ReadLine());
            decimal floorLength = decimal.Parse(Console.ReadLine());
            decimal sideTriangel = decimal.Parse(Console.ReadLine());
            decimal heightTriangle = decimal.Parse(Console.ReadLine());
            decimal priceTile = decimal.Parse(Console.ReadLine());
            decimal priceMaster = decimal.Parse(Console.ReadLine());
         
            decimal areaFloor = floorLength*floorWidth;
            decimal areaTriangle = sideTriangel * heightTriangle / 2;

            decimal TilesNeeded =  Math.Ceiling(areaFloor / areaTriangle) + 5;

            decimal overallsum = TilesNeeded * priceTile + priceMaster;

            if(overallsum<=money)
                Console.WriteLine($"{(money-overallsum):f2} lv left.");

            else
                Console.WriteLine($"You'll need {(overallsum-money):f2} lv more.");

        }
    }
}
