using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Rubik_s_Matrix
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
                 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split().Select(int.Parse).ToList();

            var matrix = new int[sizes[0], sizes[1]];

            FillMatrix(matrix);

            int n = int.Parse(Console.ReadLine());

            ReadCommands(matrix, n);

            //PrintMatrix(matrix);

            int count = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == count)
                    {
                        Console.WriteLine("No swap required");
                    }

                    else
                    {
                        Point point = GetIndexes(matrix, count);

                        Swap(i, j, point.x, point.y,matrix);

                        Console.WriteLine($"Swap ({i}, {j}) with ({point.x}, {point.y})");

                    }

                    count++;
                }

            }


        }

        private static void Swap(int i, int j, int pointX, int pointY, int[,] matrix)
        {
            int a = matrix[i, j];

            matrix[i, j] = matrix[pointX, pointY];

            matrix[pointX, pointY] = a;

            
        }


        private static Point GetIndexes(int[,] matrix, int count)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == count)
                    {
                        return new Point() {x = i, y = j};
                    }        
                } 
            }

            return new Point();


        }

        private static void ReadCommands(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                var input = Console
                    .ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (input[1] == "left")
                {
                    RotateLeft(matrix, int.Parse(input[0]), int.Parse(input[2]) % matrix.GetLength(0));
                }

                if (input[1] == "right")
                {
                    RotateLeft(matrix, int.Parse(input[0]), matrix.GetLength(0) - (int.Parse(input[2]) % matrix.GetLength(0)));
                }

                if (input[1] == "down")
                {
                    RotateDown(matrix, int.Parse(input[0]), matrix.GetLength(1) - (int.Parse(input[2]) % matrix.GetLength(1)));
                }

                if (input[1] == "up")
                {
                    RotateDown(matrix, int.Parse(input[0]), int.Parse(input[2]));
                }



            }
        }

        private static void RotateDown(int[,] matrix, int col, int rotationNumber)
        {
            int colSize = matrix.GetLength(0);
            
            int[] arr = new int[colSize];

            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                arr[k] = matrix[k,col];

            }


            for (int j = colSize-1; j >=0 ; j--)
            {
               matrix[j,col] = arr[(j + rotationNumber) % colSize];
              
            }



        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();

            }


        }

        private static void RotateLeft(int[,] matrix, int row,int rotationNumber)
        {
            int rowSize = matrix.GetLength(1);

            int[] arr = new int[rowSize];


            for (int i = 0; i < rowSize; i++)
            {
                arr[i] = matrix[row, i];
            }


            for (int i = 0; i < rowSize; i++)
            {
                matrix[row, i] = arr[(i + rotationNumber)%rowSize];
            }



        }

        private static void FillMatrix(int[,] matrix)
        {
            int count = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = count;

                    count++;

                }

            }

        }
    }
}
