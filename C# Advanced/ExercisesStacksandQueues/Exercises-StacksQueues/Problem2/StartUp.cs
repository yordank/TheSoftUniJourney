using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int X = int.Parse(input[2]);

            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(nums[i]);
            }

            int min = int.MaxValue;

         

            for (int i = 0; i < S; i++)
            {
                int x = stack.Pop();
             }

            if(stack.Count()==0)
                Console.WriteLine(0);

            else if(stack.Contains(X))
                Console.WriteLine("true");

            else
            Console.WriteLine(stack.Min());




        }
    }
}
