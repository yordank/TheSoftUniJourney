using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[2*n][];

            var indexes = new int[2*n];

            for (int i = 0; i < 2*n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                matrix[i] = input;

                indexes[i] = input.Length;


            }

            if (isEqualIndexes(indexes))
            {
                PrintMatrix(matrix,indexes );
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {indexes.Sum()}");
            }


        }

        private static void PrintMatrix(int[][] matrix, int[]indexes )
        {
            for (int i = 0; i < matrix.GetLength(0)/2; i++)
            {
                Console.Write("[");

                for (int j = 0; j < indexes[i]; j++)
                {
                    Console.Write($"{matrix[i][j]}, ");
                }

                 
                Console.Write(string.Join(", ",matrix[i + matrix.GetLength(0) / 2].Reverse()));

                Console.Write("]");

                Console.WriteLine();
            }

        }

        private static bool isEqualIndexes(int[] indexes)
        {
            int sum = indexes[0] + indexes[indexes.Length / 2];

            for (int i = 0; i < indexes.Length/2; i++)
            {
                int curSum = indexes[i] + indexes[indexes.Length / 2+i];

                if (curSum != sum)
                    return false;
            }

            return true;
        }
    }
}
