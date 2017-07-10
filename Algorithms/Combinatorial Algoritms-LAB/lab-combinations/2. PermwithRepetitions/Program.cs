using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PermwithRepetitions
{
    class Program
    {
        public static   string[] elements;
        static void Main(string[] args)
        {
            elements = Console.ReadLine().Split();

            Gen(0);

        }

        public static void Gen(int index)
        {
            
            if (index >= elements.Length)
            {
                Console.WriteLine(string.Join(" ", elements));
                return;
            }

            HashSet<string> swapped = new HashSet<string>();

            for (int i = index; i < elements.Length; i++)
            {
                if (!swapped.Contains(elements[i]))
                {
                    Swap(index, i);
                    Gen(index + 1);
                    Swap(index, i);
                    swapped.Add(elements[i]);
                }
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
