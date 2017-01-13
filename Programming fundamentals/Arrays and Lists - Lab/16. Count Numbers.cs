using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] indArray = new int[1000];

            foreach (var t in array)
            {
                indArray[t]++;
            }
            array.Sort();
            var  array2=array.Distinct();

            foreach (var t in array2)
            {
                Console.WriteLine($"{t} -> {indArray[t]}");
            }
 

        }
    }
}
