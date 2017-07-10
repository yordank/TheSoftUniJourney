using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CombwithoutRep
{
    class Program
    {
        static int k;
        static int n;
        static string[] arr;
        static string[] input;
        static void Main(string[] args)
        {
            input = Console.ReadLine().Split();

            k = int.Parse(Console.ReadLine());

            n = input.Count();

            arr = new string[k];

            Comb(0, 0);

        }

        static void Comb(int index, int start)
        {
            if (index >= k)
            {
                PrintCombinations();
            }
            else
                for (int i = start; i < n; i++)
                {
                    arr[index] = input[i];
                    Comb(index + 1, i + 1);
                }
        }

        static private void PrintCombinations()
        {
            for (int i = 0; i < arr.Count(); i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
