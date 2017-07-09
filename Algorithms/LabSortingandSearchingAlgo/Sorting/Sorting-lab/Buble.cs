using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_lab
{
    public class Buble
    {
        public static void Sort<T>(T[]arr)where T:IComparable
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (!Helpers.IsLess(arr[j], arr[j+1]))
                    {
                        Helpers.Swap(arr, j, j+1);
                    }
                }
               
            }
        }
    }
}
