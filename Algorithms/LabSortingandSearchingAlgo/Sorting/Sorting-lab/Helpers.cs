using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_lab
{
    public static class Helpers
    {
        public static void Swap<T>(T[]arr,int firstIndex,int secondIndex)
        {
            T temp = arr[firstIndex];

            arr[firstIndex] = arr[secondIndex];

            arr[secondIndex] = temp;

        }

        public static bool IsLess(IComparable first,IComparable second)
        {
            return first.CompareTo(second)<0;
        }
        public static bool isSorted<T>(T[] arr) where T:IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if(arr[i-1].CompareTo(arr[i])>0)
                {
                    return false;
                }

            }
            return true;
        }
    }
}
