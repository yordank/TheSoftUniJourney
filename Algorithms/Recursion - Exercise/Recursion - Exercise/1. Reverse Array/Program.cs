using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Reverse_Array
{
    class Program
    {

        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ReverseArray(nums, 0);


        }
        static void ReverseArray(int[]array,int index)
        {
            if (index >= array.Count())
                return;

            Console.Write($"{array[array.Count()-1-index]} ");
            ReverseArray(array, index + 1);
        } 
    }
}
