using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.N_Choose_K_Count
{
    class Program
    {
        static decimal[,] matrix;
        static void Main(string[] args)
        {
            int n= int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            matrix = new decimal[n*n, n*n];

            Console.WriteLine(Binom(n,k));
        }

        static public decimal Binom(int n, int k)
        {
            if (matrix[n, k] != 0)
                return matrix[n, k];
            if (k > n)
            {
                return 0;
            }
            if (k == 0 || k == n)
            {
                matrix[n, k] = 1;
                return 1;
            }
            matrix[n, k] = Binom(n - 1, k - 1) + Binom(n - 1, k);
            return matrix[n,k];
        }

    }
}
