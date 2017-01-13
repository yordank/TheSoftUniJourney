using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FF = long.Parse(Console.ReadLine());
            long UT = long.Parse(Console.ReadLine());



            long seconds = N * FT;
            long filteredpictures =(long)Math.Ceiling( ((double)FF / 100) * N);
            seconds += filteredpictures * UT;

            TimeSpan d = TimeSpan.FromSeconds(seconds);

 
            Console.WriteLine($" {d.ToString( @"d\:hh\:mm\:ss")}");
            

        }
    }
}
