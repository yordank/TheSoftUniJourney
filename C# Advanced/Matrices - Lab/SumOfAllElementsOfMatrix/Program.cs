using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfAllElementsOfMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(',').Select(int.Parse).ToList();

            var matrix = new int[size[0], size[1]];



            int sum = 0;

            ReadMatrix(matrix);

            sum = SumOfMatrixElems(matrix);

            Console.WriteLine(matrix.GetLength(0));

            Console.WriteLine(matrix.GetLength(1));

            Console.WriteLine(sum);


        }

        private static int SumOfMatrixElems(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
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
