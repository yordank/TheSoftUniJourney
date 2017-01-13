using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int len1 = Math.Max(array1.Length, array2.Length);
            int len2 = Math.Min(array1.Length, array2.Length);


            int[] array3 = new int[len1];
            for (int i = 0; i < len1; i++)
            {
                if(array1.Length>=array2.Length)
                array3[i] = array1[i] + array2[i%len2];
                else
                array3[i] = array1[i%len2] + array2[i];

            }

            Console.WriteLine(string.Join(" ",array3));

        }

    }
}
