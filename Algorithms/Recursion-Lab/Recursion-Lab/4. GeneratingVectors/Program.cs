using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.GeneratingVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Gen01(array, 0);
        }

        private static void Gen01(int[]vector,int index)
        {
            if(index>vector.Length-1)
            {
                Console.WriteLine(string.Join("",vector));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                vector[index] = i;
                Gen01(vector, index + 1);
            }

        }

    }
}
