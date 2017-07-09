using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_lab
{
    public static class Selection
    {
        public static void Sort<T>(T[]arr)where T :IComparable
        {
            for (int ind = 0; ind < arr.Length; ind++)
            {
                int min = ind;
                for (int current = ind+1; current < arr.Length; current++)
                {
                    if(Helpers.IsLess(arr[current],arr[min]))
                    {
                        min = current;
                    }                  

                }
                Helpers.Swap(arr, min, ind);
            }
        }

    }
}
