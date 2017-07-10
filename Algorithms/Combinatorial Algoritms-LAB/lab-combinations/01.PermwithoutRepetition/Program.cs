using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PermwithoutRepetition
{
    class Program
    {
        public static string[] elements;
        public static string[] perm;
        public static bool[] used;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();
            perm = new string[elements.Count()];
            used = new bool[elements.Count()];
            Gen1(0);

        }

        public static void Gen(int index)
        {
            if (index >= elements.Length)
                Console.WriteLine(string.Join(" ", perm));
            else
                for (int i = 0; i < elements.Length; i++)
                    if (!used[i])
                    {
                        used[i] = true;
                        perm[index] = elements[i];
                        Gen(index + 1);
                        used[i] = false;
                    }
        }


        public static void Gen1(int index)
        {
            if (index >= elements.Length)
                Console.WriteLine(string.Join(" ", elements));
            else
                Gen1(index + 1);
            for (int i = index + 1; i < elements.Length; i++)
            {
                Swap(index, i);
                Gen1(index + 1);
                Swap(index, i);
            }
        }

        private static void Swap(int index, int i)
        {
            var temp = elements[index];
            elements[index] = elements[i];
            elements[i] = temp;

        }
    }
}
