using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            printName(name);
        }
        static void printName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
