using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int n =int.Parse(Console.ReadLine());

            int[] sum= new int[t.Length];


           int  start = (t.Length - 1);


            for (int i = 0; i < n; i++)
            {
                


                for (int j = 0; j < t.Length; j++)
                {

                    sum[j]+=t[((start+j)%t.Length)];
                     
                }

                if (start>0)
                start--;
                else
                start = t.Length - 1;
                 

            }

            Console.WriteLine(string.Join(" ", sum));


        }
    }
}
