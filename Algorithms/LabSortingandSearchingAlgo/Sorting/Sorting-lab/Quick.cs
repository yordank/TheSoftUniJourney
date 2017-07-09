using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_lab
{
    public class Quick
    {
        public static void Sort<T>(T[] a) where T : IComparable<T>
        {
            Shuffle.FisherYates(a);
            Sort(a, 0, a.Length - 1);
        }
        private static void Sort<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            if (lo > hi)
            {
                return;
            }
            int p = Partition(a, lo, hi);
            Sort(a, lo, p - 1);
            Sort(a, p + 1, hi);
        }

        private static int Partition<T>(T[] a, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi)
            {
                return lo;
            }

            int i = lo;
            int j = hi + 1;

            while (true)
            {
                while (a[++i].CompareTo(a[lo])<0)
                {
                    if (i == hi) break;
                }

                while (a[lo].CompareTo(a[--j]) < 0)
                {
                    if (j==lo) break;
                }
                if (i >= j) break;
                Helpers.Swap(a, i, j);

            }

            Helpers.Swap(a, lo, j);

            return j;

        }
    }
}
