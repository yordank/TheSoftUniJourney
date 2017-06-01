using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var matrix = new string[sizes[0],sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    string value =string.Concat( alphabet[i] , alphabet[i + j] , alphabet[i]);

                    matrix[i, j] = value;

                }
            }

            Print(matrix);

        }

        private static void Print(string[,] matrix)
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
    }
}
