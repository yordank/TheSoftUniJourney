using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine($"{string.Join("",input.Select(x=> "\\u" + ((int)x).ToString("X4").ToLower()))}");

        }
    }
}
