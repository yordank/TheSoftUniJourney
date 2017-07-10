using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.VarwithoutRep
{
    class Program
    {
        public static string[] elements;
        public static string[] variation;
        public static bool[] used;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();

            int k = int.Parse(Console.ReadLine());

            variation = new string[k];

            used = new bool[elements.Count()];

            Gen(0);

        }

        public static void Gen(int index)
        {
            if (index >= variation.Length)
                Console.WriteLine(string.Join(" ", variation));
            else
                for (int i = 0; i < elements.Length; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        variation[index] = elements[i];
                        Gen(index + 1);
                        used[i] = false;
                    }
        }


        
    }


}
