using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int choice = input[0];

                if (choice == 1)
                {
                    stack.Push(input[1]);

                    if (max < input[1])
                        max = input[1];

                }

                if (choice == 2)
                {
                    stack.Pop();
                    max = stack.Max();
                }

                if (choice == 3)
                    Console.WriteLine(max);


            }

        }



    }
}
