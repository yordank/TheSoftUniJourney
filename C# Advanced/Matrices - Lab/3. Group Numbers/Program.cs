using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

            //int[] numbers = { 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
            int[] sizes = new int[3];
            foreach (var number in numbers)
            {
                int remainder = Math.Abs(number % 3);
                sizes[remainder]++;
            }

            int[][] matrix =
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            int[] offsets = new int[3];
            foreach (var number in numbers)
            {
                int remainder = Math.Abs(number % 3);
                 
                int index = offsets[remainder];
                matrix[remainder][index] = number;
                offsets[remainder]++;
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < offsets[i]; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
