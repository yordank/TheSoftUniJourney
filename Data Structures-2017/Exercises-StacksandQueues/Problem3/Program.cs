 
using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayStack<int> stack = new ArrayStack<int>();

            for (int i = 0; i < 1024; i++)
            {
                stack.Push(i);
                stack.Push(i);
                stack.Push(i);
                stack.Pop();
                stack.Pop();
            }

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
