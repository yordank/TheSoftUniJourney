using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.ConnectedAreasinaMatrix
{
    class Cell
    {
        public int x { get; set; }
        public int y { get; set; }
    }
    class Area
    {
        public Cell Cell { get; set; }
        public int Len { get; set; }
    }
    class Program
    {
        static string[,] matrix;
        static void Main(string[] args)
        {
            matrix = ReadInput();

            StringBuilder sb = new StringBuilder();

            Cell cell = FirstNotVisitedCell();

            List<Area> areas = new List<Area>();

            int count = 0;

            while (cell != null)
            {
                int len = FillMatrix(cell.x, cell.y, 0);



                areas.Add(new Area() { Cell = cell, Len = len });

                cell = FirstNotVisitedCell();

                count++;

            }
            Console.WriteLine($"Total areas found: {count}");

            count = 0;

            foreach (var area in areas.OrderByDescending(x => x.Len))
            {
                count++;

                Console.WriteLine($"Area #{count} at ({area.Cell.x}, {area.Cell.y}), size: {area.Len + 1}");

            }




        }

        private static int FillMatrix(int x, int y, int length)
        {
            matrix[x, y] = "*";

            if (x < 0 || x >= matrix.GetLength(0))
                return length - 1;
            if (y < 0 || y >= matrix.GetLength(1))
                return length - 1;

            int len = 0;
           // for (int i = 0; i < 4; i++)
            {


                if (isValid(x + 1, y))
                {
                    len+= 1 + FillMatrix(x + 1, y, length + 1);
                     
                }




                if (isValid(x - 1, y))
                {

                    len+= 1 + FillMatrix(x - 1, y, length + 1);
                   
                }




                if (isValid(x , y+1))
                {

                    len+=1 + FillMatrix(x, y + 1, length + 1);
                     
                }




                if (isValid(x , y-1))
                {

                   len+=1 + FillMatrix(x, y - 1, length - 1);
                    
                }


            }

            return len;

        }

        private static bool isValid(int x, int y)
        {
            if (x < 0 || x >= matrix.GetLength(0))
                return false;

            if (y < 0 || y >= matrix.GetLength(1))
                return false;

            if (matrix[x, y] == "-")
                return true;

            return false;

        }

        private static Cell FirstNotVisitedCell()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == "-")
                        return new Cell() { x = i, y = j };
                }
            }
            return null;
        }

        private static string[,] ReadInput()
        {
            int row = int.Parse(Console.ReadLine());

            int col = int.Parse(Console.ReadLine());

            matrix = new string[row, col];



            for (int i = 0; i < row; i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = line[j].ToString();
                }
            }

            return matrix;


        }
    }
}
