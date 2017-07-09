using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CombinationswithRep
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            loop(0, array,n,0);
        }
        static void loop(int index, int[] array,int n,int current)
        {
            if (index == array.Count())
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }
            

            for (int i = 0; i <n; i++)
            {

                if (i+1 >= current)
                {
                    array[index] = i + 1;
                    loop(index + 1, array, n, i + 1);

                }
                else
                {
                     
                }
               

            }

        }
    }
}
