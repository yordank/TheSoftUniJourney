using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3._2x2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var matrix = new string[sizes[0], sizes[1]];

            ReadMatrix(matrix);

            int count = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {

                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (FindEqual(i, j, matrix) == true)
                    {
                        count++;
                    }

                }

            }

            Console.WriteLine(count);

        }

        private static bool FindEqual(int i, int j,string [,] matrix)
        {

            string value = matrix[i, j];    

            for (int i1 = i; i1 < i+2; i1++)
            {
                for (int j1 = j; j1 < j+2; j1++)
                {

                    if (matrix[i1, j1] != value)
                    {
                        return false;
                    }
 

                }
            }

            return true;


        }

        private static void ReadMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                for (int j = 0; j < input.Count(); j++)
                {
                    matrix[i, j] = input[j];
                }


            }
        }
    }
}
