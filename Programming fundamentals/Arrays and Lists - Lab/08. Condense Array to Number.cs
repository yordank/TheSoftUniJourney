using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (array1.Length > 1)
            {
                int[] array2 = new int[array1.Length - 1];

                for (int i = 0; i < array1.Length-1; i++)
                {
                    array2[i] = array1[i] + array1[i + 1];
                }
                array1 = array2;

            }

            Console.WriteLine(array1[0]);

        }
    }
}
