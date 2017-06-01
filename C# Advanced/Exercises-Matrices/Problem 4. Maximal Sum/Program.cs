using System;
using System.Linq;

namespace Problem_4. Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var matrix = new int[sizes[0], sizes[1]];

            ReadMatrix(matrix);

            int best = 0;

            int bestX = 0;

            int bestY = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {

                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int maxSum = FindMaxSum(i, j, matrix);

                    if (maxSum >best)
                    {
                        best = maxSum;

                        bestX = i;

                        bestY = j;

                    }

                }

            }



            Console.WriteLine($"Sum = {best}");

            PrintMatrix(bestX, bestY, matrix);
        }

        private static void PrintMatrix(int bestX, int bestY, int[,] matrix)
        {
            for (int i = bestX; i < bestX+3; i++)
            {
                for (int j = bestY; j < bestY+3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();

            }
        }

        private static int FindMaxSum(int i, int j, int[,] matrix)
        {
            int sum = 0;
             

            for (int i1 = i; i1 < i + 3; i1++)
            {
                for (int j1 = j; j1 < j + 3; j1++)
                {

                    sum += matrix[i1, j1];


                }
            }

            return sum;


        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int j = 0; j < input.Count(); j++)
                {
                    matrix[i, j] = input[j];
                }


            }
        }
    }
}
