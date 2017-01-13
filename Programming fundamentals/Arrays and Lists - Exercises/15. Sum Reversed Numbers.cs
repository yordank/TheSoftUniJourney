using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ');

            int sum = 0;

            foreach (var t in array)
            {
                char[] arr = t.ToCharArray();
                Array.Reverse(arr);
                sum+=int.Parse((new string(arr)));
            }


            Console.WriteLine(sum);
        }
    }
}
