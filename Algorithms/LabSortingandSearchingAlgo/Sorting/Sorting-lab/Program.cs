using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Quick.Sort(numbers);

            Console.WriteLine(string.Join(", ",numbers));

            Console.WriteLine(BinarySearch.IndexOf(numbers,1));
            //Console.WriteLine(Helpers.isSorted(numbers));
           // Shuffle.FisherYates(numbers);

           // Console.WriteLine(string.Join(", ", numbers));

        }
    }


}
