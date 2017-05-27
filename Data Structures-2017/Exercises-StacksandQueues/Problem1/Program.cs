using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(input);

            while (stack.Count!=0)
            {
                Console.Write($"{stack.Pop()} ");
            }

        }
    }
}
