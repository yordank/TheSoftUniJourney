using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Problems
{
    public class Problem8
    {
        public string[,] solution(string[,]arr)
        {
            int n = (int)Math.Sqrt((double)arr.Length);

            Queue<int> q = new Queue<int>();

            int[] start = findStartPosition(arr);

            q.Enqueue(start[0]);

            q.Enqueue(start[1]);

            q.Enqueue(1);

            while (q.Count > 0)
            {

                int x = q.Dequeue();

                int y = q.Dequeue();

                int value = q.Dequeue();

               

                try
                {
                    if (arr[x - 1, y] == "0")
                    {
                        arr[x - 1, y] = value.ToString();

                        q.Enqueue(x - 1);

                        q.Enqueue(y);

                        q.Enqueue(value + 1);
                    }

                }
                catch
                {

                }

                try
                {
                    if (arr[x + 1, y] == "0")
                    {
                        arr[x + 1, y] = value.ToString();

                        q.Enqueue(x + 1);

                        q.Enqueue(y);

                        q.Enqueue(value + 1);
                    }


                }
                catch
                {
                    
                }
                try
                {
                    if (arr[x, y-1] == "0")
                    {
                        arr[x, y - 1] = value.ToString();

                        q.Enqueue(x);

                        q.Enqueue(y - 1);

                        q.Enqueue(value + 1);
                    }

                }
                catch
                {

                }
                try
                {
                    if (arr[x, y+1] == "0")
                    {
                        arr[x, y + 1] = value.ToString();

                        q.Enqueue(x);

                        q.Enqueue(y + 1);

                        q.Enqueue(value + 1);

                    }


                }
                catch
                {

                }
               
            }

           

             return arr;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{arr[i,j]} ");
            //    }

            //    Console.WriteLine();
            //}


        }

        private int[] findStartPosition(string[,] arr)
        {
            int n =(int)Math.Sqrt((double)arr.Length);

            int[] startPosition = new int[2];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == "*")
                    {
                        startPosition[0] = i;
                        startPosition[1] = j;
                        return startPosition;
                    }
                }

            }

            return startPosition;

        }

    }
}
