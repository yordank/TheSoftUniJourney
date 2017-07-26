using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public  class Sorter<T>

{
    public static void Sort<T>(CustomList<T> list)
          where T : IComparable,IEnumerable
    {
        list.List.Sort();
    }
}

