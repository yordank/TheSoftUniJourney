using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Recursive_Array_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(Sum(array,0));
        }
        private static int Sum(int[]array,int index)
        {
            if (index == array.Count() - 1)
                return array[index];

            else
                return array[index] + Sum(array, index + 1);

        }
    }
}
