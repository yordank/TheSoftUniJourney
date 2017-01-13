using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string var1 = "Hello";
            string var2 = " World";
            string s = string.Concat(var1, var2);
            object var3 = (object)(s);
            string var4 = (string)var3;

            Console.WriteLine(var4);

        }
    }
}
