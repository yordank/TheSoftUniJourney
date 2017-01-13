using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = Console.ReadLine().Split(' ') ;
            var input2 = Console.ReadLine().Split(' ');

            if (func(input1, input2) == 1)
            {
                Console.WriteLine(string.Join("", input1));
                Console.WriteLine(string.Join("", input2));
            }

            if (func(input1, input2) == 2)
            {
                Console.WriteLine(string.Join("", input2));
                Console.WriteLine(string.Join("", input1));
            }
        }

        static int func(string[] a, string[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i >= b.Length) return 2;

                if ( Convert.ToChar( a[i]) < Convert.ToChar(b[i])) return 1;
                if (Convert.ToChar(a[i]) > Convert.ToChar(b[i])) return 2;

            }

            return 1;
        }


    }
}
