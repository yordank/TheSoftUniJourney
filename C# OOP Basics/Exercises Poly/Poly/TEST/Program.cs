using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int x = int.Parse(Console.ReadLine());

        //Array.Sort(arr);

        int index = BinarySearch(arr, x, 0, arr.Length - 1);
        Console.WriteLine(index);
    }
    private static int BinarySearch(int[] arr, int x, int low, int high)
    {
        if (low > high)
        {
            return -1;
        }
        int mid = (high + low) / 2;
        if (arr[mid] == x)
        {
            return mid;
        }
        else
        {
            if (arr[mid] > x)
            {
                return BinarySearch(arr, x, low, mid - 1);
            }
            else
            {
                return BinarySearch(arr, x, mid + 1, high);
            }
        }
    }

}
