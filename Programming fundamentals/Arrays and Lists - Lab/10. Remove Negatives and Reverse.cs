using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).Where(x => x > 0).ToArray();

            if (array.Length > 0)
                Console.WriteLine(string.Join(" ", array.Reverse()));
            else
                Console.WriteLine("empty");
        }
    }
}
