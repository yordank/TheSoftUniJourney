using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            Console.WriteLine((float)meters / (hours * 60 * 60 + minutes * 60 + seconds));
            Console.WriteLine((float)(meters/1000) / (hours+(float)minutes/60+(float)seconds/3600));
            Console.WriteLine((float)meters / 1609 / (hours + (float)minutes / 60 + (float)seconds / 3600));


        }
    }
}
