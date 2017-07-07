using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_III___Find_All_Paths_in_a_Labyrinth
{
    class Program
    {
        static string[,] lab;
        static List<char> path = new List<char>();
        static void Main(string[] args)
        {
            lab = ReadLab();

            FindPaths(0, 0, 'S');
        }

        private static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBounds(row, col))
                return;

            path.Add(direction);

            if(IsExit(row,col))
            {
                PrintPath();
                return;
            }
            else if(!isVisited(row,col) && isFree(row,col))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row+1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row-1, col, 'U');
                Unmark(row, col);


            }
            else
            {
                path.RemoveAt(path.Count - 1);
            }
        }

        private static void Unmark(int row, int col)
        {
            lab[row, col] = "-";
            path.RemoveAt(path.Count - 1);
        }

        private static void Mark(int row, int col)
        {
            lab[row, col] = "*";
        }

        private static bool isVisited(int row, int col)
        {
            if (lab[row, col] != "-")
                return true;
            return false;
        }

        private static void PrintPath()
        {
            Console.WriteLine(string.Join("",path));
            path.RemoveAt(path.Count - 1);
        }

        private static bool IsExit(int row, int col)
        {
            if (lab[row, col] == "e")
                return true;

            return false;
        }

        private static bool IsInBounds(int row, int col)
        {
            if (row < 0 || row >= lab.GetLength(0))
            {
                 
                return false;

            }
            if (col < 0 || col >= lab.GetLength(1))
            {
               
                return false;
            }

          //  if(lab[row,col]=="-")
            return true;
          
        }

        private static bool isFree(int row, int col)
        {
            if (lab[row, col] == "-")
                return true;
            return false;
        }

        private static string[,] ReadLab()
        {
            int row = int.Parse(Console.ReadLine());

            int col = int.Parse(Console.ReadLine());

            lab = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                var line = Console.ReadLine().ToCharArray();

                for (int j = 0; j < col; j++)
                {
                    lab[i, j] = line[j].ToString();
                }
            }

            return lab;

        }
    }
}
