using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Needles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            decimal[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions
                .RemoveEmptyEntries).Select(x => decimal.Parse(x))
                .ToArray();

            for (int i = numbers.Count()-1; i >=0 ; i--)
            {
                if (numbers[i] == 0 && i !=numbers.Count()-1)
                    numbers[i] = numbers[i + 1] + 000.1m;
                else
                    numbers[i] += 0.1m;

            }

            int[] needles = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < needles.Count(); i++)
            {
                Console.Write($"{BinarySearch.IndexOf(numbers,needles[i])} ");
            }

        }
        
        public class BinarySearch
        {
            public static int IndexOf(decimal[] arr, int key)
            {
                int lo = 0;
                int hi = arr.Length - 1;

                while (lo <= hi)
                {
                    int mid = lo + (hi - lo) / 2;

                    if (key < arr[mid])
                    {
                        hi = mid - 1;
                    }
                    else if (key > arr[mid])
                    {
                        lo = mid + 1;
                    }
                    else
                    {
                        return mid;
                    }

                }

                return lo;

            }
        }
    }
}
