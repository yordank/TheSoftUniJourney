using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sumleft = 0;
            int sumright = 0;
            int flag = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                    sumleft += arr[j];

                for (int j = i+1; j < arr.Length; j++)
                    sumright += arr[j];

                if (sumleft == sumright)
                {
                    flag = 1;
                    Console.WriteLine(i);
                }

                sumleft = 0;
                sumright = 0;

            }
            if (flag == 0)
                Console.WriteLine("no");

        }
    }
}
