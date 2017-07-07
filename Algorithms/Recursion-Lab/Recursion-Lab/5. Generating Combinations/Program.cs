using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Generating_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = int.Parse(Console.ReadLine());
            int[] array = new int[k];
            GenCombs(nums, array, 0, 0);
        }
        private static void GenCombs(int[]set,int[] vector,int index,int border)
        {
            if(index==vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];

                    GenCombs(set, vector, index + 1, i + 1);
                }
            }

        }
    }
}
