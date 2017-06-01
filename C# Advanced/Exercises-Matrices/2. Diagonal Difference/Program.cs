using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = input[j];
                }

            }

            int primaryDiagonal = FindPrimaryDiagonal(matrix);

            int secondaryDiagonal = FindSecondaryDiagonal(matrix);

            Console.WriteLine(Math.Abs(primaryDiagonal-secondaryDiagonal));


        }

        private static int FindSecondaryDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }

            return sum;
        }

        private static int FindPrimaryDiagonal(int[,] matrix)
        {
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, matrix.GetLength(0)-1-i];
            }

            return sum;

        }
    }
}
