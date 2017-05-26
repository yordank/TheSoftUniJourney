using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            long [] arr = new long[50];

            long n = long.Parse(Console.ReadLine());

            Console.WriteLine(getFibonacci(n,arr));

        }

        static long getFibonacci(long n,long [] arr)
        {
            if (n == 1)
            {
                arr[1] = 1;
                return 1;
                
            }


            if (n == 2)
            {
                arr[2] = 1;
                return 1;
            }

            long prev;
            long prevprev;

            if(arr[ n-1]!=0)
            {
                prev = arr[n - 1];
            }
            else
            {
                
                prev= getFibonacci(n - 1, arr);
                arr[n - 1] = prev;
            }

            if (arr[n - 2] != 0)
            {
                prevprev = arr[n - 2];
            }
            else
            {

                prevprev = getFibonacci(n - 2, arr);
                arr[n - 2] = prevprev;
            }

            return prev + prevprev;
        }

    }
}
