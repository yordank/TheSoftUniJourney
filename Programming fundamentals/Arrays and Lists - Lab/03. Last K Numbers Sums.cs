using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Last_K_Numbers_Sums_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] arr = new long[n];
            arr[0] = 1;
            for (long i = 1; i < n; i++)
            {
                long sum = 0;
                long j=i-k;

                if (j < 0)
                    j = 0;

                for (; j < i; j++)
                    sum += arr[j];

                arr[i] = sum;

            }

            Console.WriteLine(string.Join(" ",arr));

        }
    }
}
