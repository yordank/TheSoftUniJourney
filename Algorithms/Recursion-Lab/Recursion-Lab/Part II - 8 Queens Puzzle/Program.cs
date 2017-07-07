using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_II___8_Queens_Puzzle
{
    class EightQueens
    {
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
    }
    

    class Program
    {
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColums = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();
        static bool[,] chessboard = new bool[8, 8];
        static int solutionsFound = 0;
        static int Size = 8;
        static void Main(string[] args)
        {
            PutQueens(0);
        }

        static void PutQueens(int row)
        {
            if(row==Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if(CanPlaceQueen(row,col))
                    {
                        MarkAllAttackedPosition(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }

                }
            }
        }

        private static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessboard[row, col] == true)
                        Console.Write("* ");
                    else
                        Console.Write("- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionsFound++;
        }

        private static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColums.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(row + col);
            chessboard[row, col] = false;
        }

        private static void MarkAllAttackedPosition(int row, int col)
        {
            attackedRows.Add(row);
            attackedColums.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(row + col);
            chessboard[row, col] = true;
        }

        private static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied = attackedRows.Contains(row) ||
                attackedColums.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals.Contains(row + col);

            return !positionOccupied;
        }
    }
}
