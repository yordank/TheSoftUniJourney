using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startindex = int.Parse(Console.ReadLine());
            int endindex = int.Parse(Console.ReadLine());

            for (int i = startindex; i <= endindex; i++)
                Console.Write($"{(char)i} ");
        }
    }
}
