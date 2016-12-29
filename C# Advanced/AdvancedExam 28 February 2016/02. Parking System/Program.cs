using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Parking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToList();

            var parking = new bool[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    parking[i, j] = false;
                }
            }

            string input = Console.ReadLine();

            while (input != "stop")
            {

                var indexes = input.Split().Select(int.Parse).ToList();

                int firstFree = ClosestFree(indexes[1], indexes[2], parking, dimensions[1]);

                if (firstFree != -1)
                {
                    int distance = 0;
                    if (parking[indexes[1], indexes[2]] == false)
                    {
                        distance = Math.Abs(indexes[0] - indexes[1]) + Math.Abs(indexes[2] + 1);
                        parking[indexes[1], indexes[2]] = true;
                    }
                    else
                    {
                        distance = Math.Abs(indexes[0] - indexes[1]) + Math.Abs(firstFree + 1);
                        parking[indexes[1], firstFree] = true;
                    }

                    Console.WriteLine(distance);
                }
                else
                {
                    Console.WriteLine($"Row {indexes[1]} full");
                }

                input = Console.ReadLine();
            }

        }

        private static int ClosestFree(int row, int col, bool[,] parking, int len)
        {

            if (parking[row, col] == false)
                return col;

            int findIndexLeft = -1;
            int findIndexRight = -1;

            for (int i = col - 1; i >= 1; i--)
            {

                if (parking[row, i] == false)
                {
                    findIndexLeft = i;
                    break;
                }

            }


            for (int i = col + 1; i < len; i++)
            {

                if (parking[row, i] == false)
                {
                    findIndexRight = i;
                    break;
                }

            }

            if (findIndexLeft == -1 && findIndexRight == -1)
                return -1;

            if (findIndexLeft == -1)
                return findIndexRight;

            if (findIndexRight == -1)
                return findIndexLeft;

            if (col - findIndexLeft <= findIndexRight - col)
                return findIndexLeft;
            else
                return findIndexRight;

        }





    }
}
