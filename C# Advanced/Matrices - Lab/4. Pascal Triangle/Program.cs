using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var rows = long.Parse(Console.ReadLine());
            long[][] triangle = new long[rows][];
            long currentWidth = 1;
            for (long height = 0; height < rows; height++)
            {
                triangle[height] = new long[currentWidth];
                long[] currentRow = triangle[height];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                currentWidth++;
                //TODO: Fill elements for each row (next slide)

                if (currentRow.Length > 2)
                {
                    for (long i = 1; i < currentRow.Length - 1; i++)
                    {
                        long[] previousRow = triangle[height - 1];
                        long prevoiousRowSum = previousRow[i] + previousRow[i - 1];
                        currentRow[i] = prevoiousRowSum;
                    }
                }

            }

            PrlongTriangle(triangle);


        }

        private static void PrlongTriangle(long[][] triangle)
        {
            long currentWidth = 1;

            for (long i = 0; i < triangle.GetLength(0); i++)
            {
                for (long j = 0; j < currentWidth; j++)
                {
                    Console.Write($" {triangle[i][j]}");
                }

                Console.WriteLine();

                currentWidth++;
            }

        }
    }
}
