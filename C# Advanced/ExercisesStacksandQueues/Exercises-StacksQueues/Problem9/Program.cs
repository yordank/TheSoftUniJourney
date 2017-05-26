using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            Stack<long> stack = new Stack<long>();

            stack.Push(1);

            stack.Push(1);

            for (long i = 2; i < n; i++)
            {
                long n1 = stack.Pop();
                long n2 = stack.Pop();
                stack.Push(n1);
                stack.Push(n1 + n2);
            }
            Console.WriteLine(stack.Peek());

        }
    }
}
