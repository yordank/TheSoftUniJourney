using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NestedLoopsToRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            loop(0, array);

        }

        static void loop(int index,int[]array)
        {
            if(index==array.Count())
            {
                Console.WriteLine(string.Join(" ",array));
                return;
            }

            for (int i = 0; i < array.Count(); i++)
            {
                array[index] = i+1;

                loop(index + 1, array);
                
            }

        }
    }
}
