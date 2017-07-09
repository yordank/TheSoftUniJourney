using System;
using System.Linq;


class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            loop(0, array, n, 0);
        }
        static void loop(int index, int[] array, int n, int current)
        {
            if (index == array.Count())
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }


            for (int i = current; i < n; i++)
            {

                
                    array[index] = i + 1;
                    loop(index + 1, array, n, i + 1);

               


            }

        }
    }
 
