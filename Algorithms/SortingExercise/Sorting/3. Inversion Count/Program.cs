using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Inversion_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int res=getInvCount(nums,nums.Count());

            Console.WriteLine(res);

        }

        static private int getInvCount(int[] arr, int n)
        {
            int inv_count = 0;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (arr[i] > arr[j])
                        inv_count++;

            return inv_count;
        }
    }

   



}
