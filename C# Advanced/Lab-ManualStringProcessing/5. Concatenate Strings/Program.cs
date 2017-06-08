using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Concatenate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var output = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                output.Append(Console.ReadLine());
                output.Append(" ");

            }

            Console.WriteLine(output);
        }
    }
}
