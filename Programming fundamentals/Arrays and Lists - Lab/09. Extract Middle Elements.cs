using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Extract_Middle_1__2_or_3_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            extractAndPrint(array);
        }
        static void extractAndPrint(int[] array)
        {
            int len = array.Length;
            if (len == 1)
            {
                Console.WriteLine($"{{ {array[0]} }}");
                return;
            }
            if (len % 2 == 0)
                Console.WriteLine($"{{ {array[len/2-1]}, {array[len / 2 ]} }}");
            if (len % 2 != 0)
                Console.WriteLine($"{{ {array[(len-1) / 2 - 1]}, {array[(len-1) / 2]}, {array[(len - 1) / 2+1]} }}");
        }
    }
}
