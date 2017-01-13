using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printTriangle(n);
        }

        static void printTriangle(int n)
        {
            
            for (int i = 1; i < n; i++)
            {
                
                printLine(1,i);
               
            }
            printLine(1, n);
            for (int i = n-1; i >=1; i--)
            {

                printLine(1, i);

            }

        }

        static void printLine(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }

    }
}
