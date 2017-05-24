using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Value { get; set; }

        }


        static void Main(string[] args)
        {
           

            int n = int.Parse(Console.ReadLine());

            string[,] arr = new string[n, n];

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();

                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = inputLine[j].ToString();
                }

            }

            Queue<Point> q = new Queue<Point>();

            q.Enqueue(findTheStart(arr));

            while(q.Count()>0)
            {
                Point currentPoint = q.Dequeue();

                int x = currentPoint.X;
                int y = currentPoint.Y;
                int value = currentPoint.Value;

                try
                {

                    if (arr[x-1,y]=="0")
                    {

                        Point newPoint = new Point()
                        {
                            X = x - 1,
                            Y = y,
                            Value = value + 1
                        };
                        arr[x-1, y] = (value + 1).ToString();
                        q.Enqueue(newPoint);

                    }
                }

                catch
                {

                }

                try
                {

                    if (arr[x + 1, y] == "0")
                    {

                        Point newPoint = new Point()
                        {
                            X = x + 1,
                            Y = y,
                            Value=value+1
                        };
                        arr[x+1, y] = (value + 1).ToString();
                        q.Enqueue(newPoint);

                    }

                }
                catch
                {

                }


                try
                {

                    if (arr[x, y-1] == "0")
                    {

                        Point newPoint = new Point()
                        {
                            X = x ,
                            Y = y-1,
                            Value=value+1
                        };
                        arr[x, y-1] = (value + 1).ToString();
                        q.Enqueue(newPoint);

                    }

                }
                catch
                {

                }


                try
                {

                    if (arr[x, y+1] == "0")
                    {

                        Point newPoint = new Point()
                        {
                            X = x,
                            Y = y+1,
                            Value=value+1
                        };
                        arr[x, y+1] = (value + 1).ToString();
                        q.Enqueue(newPoint);

                    }
                }
                catch
                {

                }



            }
            setSymbolWhere0remains(arr);

            Print(arr);

        }

        private static void setSymbolWhere0remains(string[,] arr)
        {
            int n = (int)Math.Sqrt(arr.Length);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == "0")
                        arr[i, j] = "u";
                }
            }
        }

        static void Print(string [,]arr)
        {
            int n = (int)Math.Sqrt(arr.Length);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i,j]}");
                }

            }

        }
        static Point findTheStart(string [,]arr)
        {
            int n =(int) Math.Sqrt(arr.Length);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(arr[i,j]=="*")
                    {
                        return new Point()
                        {
                            X = i,
                            Y = j
                         };

                    }
                }

            }

            return new Point()
            {
                X = 0,
                Y = 0,
                Value = 0
            };

        }

    }
}
