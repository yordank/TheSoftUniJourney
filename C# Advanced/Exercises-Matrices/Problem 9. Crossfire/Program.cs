using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToList();

            var matrix = new short[size[0]][];

            FillMatrix(size, matrix);

            var input = Console.ReadLine();

            int rows = size[0];

            while (input != "Nuke it from orbit")
            {
                var items = input.Split().Select(int.Parse).ToList();

                int x = items[0];

                int y = items[1];

                int radius = items[2];

                MarkElements(matrix, x, y, radius);

                int row = 0;



                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i].Where(x1 => x1 != -1).Count() > 0)
                    {
                        matrix[row] = matrix[i].Where(x1 => x1 != -1).ToArray();
                        row++;
                    }

                }

                rows = row;

                input = Console.ReadLine();

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }

                Console.WriteLine();
            }

        }

        private static bool IsInMatrix(int row, int col, short[][] matrix)
        {
            return row >= 0 && col >= 0 && row < matrix.Length && col < matrix[row].Length;
        }

        private static void MarkElements(short[][] matrix, int x, int y, int radius)
        {
            int rows = y+radius;

            if (x>=0 && x<matrix.GetLength(0))
            {
                if( y + radius > matrix[x].Length)
                rows = matrix[x].Length - 1;
            }

            int len = y + radius;

             

            for (int i = Math.Max(y - radius, 0); i <= rows; i++)
            {
                if (IsInMatrix(x, i, matrix))
                {
                    matrix[x][i] = -1;
                }
                 

            }

            for (int i = Math.Max(0, x - radius); i <= x + radius; i++)
            {

                if (IsInMatrix(i, y, matrix))
                {
                    matrix[i][y] = -1;
                }

                

            }
        }

        private static void FillMatrix(List<int> size, short[][] matrix)
        {
            short currentNumber = 1;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new short[size[1]];

                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = currentNumber;
                    currentNumber++;
                }
            }
        }



    }
}
