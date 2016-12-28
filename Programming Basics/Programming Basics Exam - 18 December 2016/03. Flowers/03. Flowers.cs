using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());

            string season=Console.ReadLine();
            string isHoliday = Console.ReadLine();

            decimal price = 0;

            if (season == "Spring" || season == "Summer")
            {
                price = chrysanthemums * 2 + roses * (decimal)4.1 + tulips * (decimal)2.5;
            }
            if (season == "Autumn" || season == "Winter")
            {
                price = chrysanthemums * (decimal)3.75 + roses * (decimal)4.5 + tulips * (decimal)4.15;
            }
            if (isHoliday == "Y")
                price *= (decimal)1.15;

            if (tulips > 7 && season == "Spring")
            {
                price *= (decimal)0.95;
            }

            if (roses >=10 && season == "Winter")
            {
                price *= (decimal)0.90;
            }

            if (tulips+roses+chrysanthemums > 20)
            {
                price *= (decimal)0.80;
            }

            price += 2;

            Console.WriteLine($"{price:f2}");

        }
    }
}
