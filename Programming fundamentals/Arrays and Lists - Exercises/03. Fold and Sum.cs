using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var header = input.Take(input.Length / 4);
            var footer = input.Skip(3*input.Length / 4).Take(input.Length/4);

            var arr1 = header.Reverse().ToArray().Concat(footer.Reverse().ToArray());
            //Console.WriteLine(string.Join(" ", arr1));
            var arr2= input.Skip( input.Length / 4).Take(input.Length / 2);

            int[] arr3 = new int[input.Length / 2];

            for (int i = 0; i < arr1.Count(); i++)
                arr3[i]=arr1.ElementAt(i) + arr2.ElementAt(i);

            Console.WriteLine(string.Join(" ", arr3));

        }
    }
}
