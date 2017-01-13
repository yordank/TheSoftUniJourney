using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i; j < arr.Length; j++)
                    if (Math.Abs(arr[i] - arr[j]) == n)
                        count++;
            Console.WriteLine(count);

          
        }
    }
}
