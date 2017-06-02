using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse).ToList();

            var input = Console.ReadLine().ToCharArray();

            var coord = Console.ReadLine().Split().Select(int.Parse).ToList();

            var matrix = new char[sizes[0], sizes[1]];

            int count = 0;

            int ind = 0;

            ReadMatrix(sizes, input, matrix, ref count, ref ind);

            killCells(matrix, coord);

            moveDown(matrix);

            PrintMatrix(sizes, matrix);

        }

        private static void moveDown(char[,] matrix)
        {
            //var matrix2 = new char[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = matrix.GetLength(0)-1; i >=0; i--)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == ' ')
                    {
                        int k = i;
                        while (k >= 0)
                        {
                            if (matrix[k, j] != ' ')
                            {
                                char a = matrix[i, j];

                                matrix[i, j] = matrix[k, j];

                                matrix[k, j] = a;

                               break;
                            }
                            k--;
                        }
                    }
                }
            }

        }

        private static void killCells(char[,] matrix, List<int> coord)
        {
            int x = coord[0];
            int y = coord[1];
            int size = coord[2];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((x - i) * (x - i) + (y - j) * (y - j) <= size * size)
                        matrix[i, j] = ' ';
                }
            }

        }

        private static void PrintMatrix(List<int> sizes, char[,] matrix)
        {
            for (int i = 0; i < sizes[0]; i++)
            {
                for (int j = 0; j < sizes[1]; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void ReadMatrix(List<int> sizes, char[] input, char[,] matrix, ref int count, ref int ind)
        {
            for (int i = sizes[0] - 1; i >= 0; i--)
            {
                if (count % 2 == 0)
                {
                    for (int j = sizes[1] - 1; j >= 0; j--)
                    {
                        matrix[i, j] = input[ind % input.Length];
                        ind++;
                    }
                }

                else
                {
                    for (int j = 0; j < sizes[1]; j++)
                    {
                        matrix[i, j] = input[ind % input.Length];
                        ind++;
                    }
                }

                count++;

            }
        }
    }
}
