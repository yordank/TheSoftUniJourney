using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            input+= Console.ReadLine();
            input+= Console.ReadLine();
            input+=Console.ReadLine();
            var str = input.ToCharArray();
            Array.Reverse(str);
            Console.WriteLine(str);
        }
    }
}
