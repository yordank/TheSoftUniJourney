using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(2*n);
            for(int i=0;i<n-2;i++)
            PrintMiddleRow(2*n);
            PrintFooterRow(2*n);

        }

        static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', n));
        }


        static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 0; i < (n - 2) / 2; i++)
                Console.Write("\\/");
            Console.WriteLine("-");
        }


        static void PrintFooterRow(int n)
        {
            Console.WriteLine(new string('-', n));
        }

    }
}
