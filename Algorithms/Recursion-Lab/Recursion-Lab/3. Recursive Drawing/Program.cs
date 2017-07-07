using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Recursive_Drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(int.Parse(Console.ReadLine()));
        }
        static void Draw(int n)
        {
            if (n == 0)
                return;


            Console.WriteLine(new string('*',n));
            Draw(n - 1);
            Console.WriteLine(new string('#', n));
        }
    }
}
