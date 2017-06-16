using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Upper_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(' ')
                .Select(w => w.ToUpper())
                .ToList()
                .ForEach(w => Console.Write(w + " "));

        }
    }
}
