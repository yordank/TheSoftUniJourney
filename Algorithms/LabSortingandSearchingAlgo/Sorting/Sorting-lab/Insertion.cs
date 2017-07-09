using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_lab
{
    public static class Insertion
    {
        public static void Sort<T>(T[]arr)where T:IComparable
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int prev = i-1;
                int curr = i;

                while(true)
                {
                    if(prev < 0 || Helpers.IsLess(arr[prev], arr[curr]) )
                    {
                        break;
                    }
                    Helpers.Swap(arr, curr, prev);
                    prev--;
                    curr--;
                }
            }
        }
    }
}
