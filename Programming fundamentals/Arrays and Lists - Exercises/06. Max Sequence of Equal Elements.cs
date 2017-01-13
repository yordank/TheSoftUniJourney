using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //  Console.WriteLine(string.Join("", arr));

            int start = 0;
            int end = 0;
            int maxd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    int count = 0;
                    int elem = arr[j];
                    for (int k = 0; k < j - i; k++)
                    {
                        if (arr[i + k] != elem) break;
                        count++;
                    }
                    if (count == j - i && count > maxd)
                    {
                        start = i;
                        end = j;
                        maxd = count;
                    }


                }
            }

            for (int i = start; i <= end; i++)
                Console.Write($"{arr[i]} ");

        }
    }
}
