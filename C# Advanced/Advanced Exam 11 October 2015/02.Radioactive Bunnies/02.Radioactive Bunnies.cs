using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Radioactive_Bunnies
{
    class Bunny
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<Bunny> bunnies = new List<Bunny>();

            var RowCols = Console.ReadLine().Split().Select(int.Parse).ToList();

            char[,] matrix = new char[RowCols[0], RowCols[1]];

            int PlayerX=0;
            int PlayerY=0;

            for (int i = 0; i < RowCols[0]; i++)
            {
                string line = Console.ReadLine();

                for (int j = 0; j < RowCols[1]; j++)
                {
                    matrix[i, j] = line[j];

                    if (line[j] == 'P')
                    {
                        PlayerX = i;
                        PlayerY = j;
                    }

                    if (line[j] == 'B')
                    {
                        Bunny bunny = new Bunny();
                        bunny.X = i;
                        bunny.Y = j;

                        bunnies.Add(bunny);

                    }

                }


            }

            string moves = Console.ReadLine();

            for (int i = 0; i < moves.Count(); i++)
            {
               
                PlayerMove(ref PlayerX, ref PlayerY,ref matrix,moves[i],RowCols[0],RowCols[1],bunnies);
                BunniesMove(ref matrix,RowCols[0],RowCols[1],bunnies);
            }



        }

        private static void BunniesMove(ref char[,] matrix,int rows,int cols,List<Bunny>bunnies)
        {
            List<Bunny> currentbunnies = new List<Bunny>(bunnies);
            foreach (var item in currentbunnies)
            {
                if (item.X - 1 >= 0)
                {
                    if (matrix[item.X - 1, item.Y] != 'B')
                    {
                        matrix[item.X - 1, item.Y] = 'B';
                        Bunny bunny = new Bunny();
                        bunny.X = item.X - 1;
                        bunny.Y = item.Y;
                        bunnies.Add(bunny);
                        
                    }
                }

                if (item.X+1 < rows)
                {
                    if (matrix[item.X + 1, item.Y] != 'B')
                    {
                        matrix[item.X + 1, item.Y] = 'B';
                        Bunny bunny = new Bunny();
                        bunny.X = item.X + 1;
                        bunny.Y = item.Y;
                        bunnies.Add(bunny);
                    }
                }

                if (item.Y - 1 >= 0)
                {
                    if (matrix[item.X , item.Y-1] != 'B')
                    {
                        matrix[item.X , item.Y-1] = 'B';
                        Bunny bunny = new Bunny();
                        bunny.X = item.X;
                        bunny.Y = item.Y-1;
                        bunnies.Add(bunny);
                    }
                }

                if (item.Y + 1 <cols)
                {
                    if (matrix[item.X, item.Y + 1] != 'B')
                    {
                        matrix[item.X, item.Y + 1] = 'B';
                        Bunny bunny = new Bunny();
                        bunny.X = item.X;
                        bunny.Y = item.Y + 1;
                        bunnies.Add(bunny);
                    }
                }


            }




        }

        private static void PlayerMove(ref int PlayerX, ref int PlayerY,ref char[,] matrix,char move,int rows,int cols,List<Bunny>bunnies)
        {
            if (matrix[PlayerX, PlayerY] == 'B')
            {
               // BunniesMove(ref matrix, rows, cols, bunnies);
                print(matrix, rows, cols);
                Console.WriteLine($"dead: {PlayerX} {PlayerY}");
                System.Environment.Exit(1912);
            }

            if (move == 'U')
            {
                


                matrix[PlayerX, PlayerY] = '.';
                PlayerX = (PlayerX - 1) ;

                if (PlayerX < 0)
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"won: {0} {PlayerY}");
                    System.Environment.Exit(1912);
                }

                if(matrix[PlayerX, PlayerY] == 'B')
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"dead: {PlayerX} {PlayerY}");
                    
                    System.Environment.Exit(1912);
                }

                matrix[PlayerX, PlayerY] = 'P';
            }

            if (move == 'D')
            {
               
                matrix[PlayerX, PlayerY] = '.';
                PlayerX = (PlayerX + 1);

                if (PlayerX >=rows)
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"won: {rows-1} {PlayerY}");
                    System.Environment.Exit(1913);
                }

                if (matrix[PlayerX, PlayerY] == 'B')
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"dead: {PlayerX} {PlayerY}");
                    System.Environment.Exit(1912);
                }

                matrix[PlayerX, PlayerY] = 'P';
            }

            if (move == 'L')
            {
                matrix[PlayerX, PlayerY] = '.';
                PlayerY = (PlayerY - 1);

                if (PlayerY < 0)
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"won: {PlayerX} {0}");
                    System.Environment.Exit(1914);
                }

                if (matrix[PlayerX, PlayerY] == 'B')
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"dead: {PlayerX} {PlayerY}");
                    System.Environment.Exit(1912);
                }

                matrix[PlayerX, PlayerY] = 'P';
            }

            if (move == 'R')
            {
                matrix[PlayerX, PlayerY] = '.';
                PlayerY = (PlayerY + 1);

                if (PlayerY >= cols)
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"won: {PlayerX} {cols-1}");
                    System.Environment.Exit(1915);
                }

                if (matrix[PlayerX, PlayerY] == 'B')
                {
                    BunniesMove(ref matrix, rows, cols, bunnies);
                    print(matrix,rows,cols);
                    Console.WriteLine($"dead: {PlayerX} {PlayerY}");
                    System.Environment.Exit(1912);
                }

                matrix[PlayerX, PlayerY] = 'P';
            }


        }

        private static void print(char[,] matrix,int rows,int cols)
        {
            for (int i = 0; i < rows; i++)
            {
               for (int j = 0; j < cols; j++)
                {

                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }




    }
}
