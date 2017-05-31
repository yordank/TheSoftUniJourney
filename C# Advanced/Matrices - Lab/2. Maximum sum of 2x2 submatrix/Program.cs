using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Maximum_sum_of_2x2_submatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            var matrix = new int[size[0], size[1]];

            int sum = 0;

            ReadMatrix(matrix);

            int bestSum = 0;

            int indexX = -1;
            int indexY = -1;


            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {

                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int currentSum = SumOfMatrix(matrix, i, j, i + 1, j + 1);

                    if (currentSum>bestSum)
                    {
                        bestSum = currentSum;
                        indexX = i;
                        indexY = j;
                    }

                }


            }

            if (indexX != -1 && indexY != -1)
            {
                PrintMatrix(matrix, indexX, indexY, indexX + 1, indexY + 1);

                Console.WriteLine(bestSum);

            }


        }
        private static void PrintMatrix(int[,] matrix, int x1, int y1, int x2, int y2)
        {
             
            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            

        }
        private static int SumOfMatrix(int[,] matrix, int x1, int y1, int x2, int y2)
        {
            int sum = 0;

            for (int i = x1; i <= x2; i++)
            {
                for (int j = y1; j <= y2; j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;

        }
        private static void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split(',').Select(int.Parse).ToList();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }

            }
        }


    }
}
