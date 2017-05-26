using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            int N = int.Parse(input[0]);
            int S = int.Parse(input[1]);
            int X = int.Parse(input[2]);

            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(nums[i]);
            }

            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count() == 0)
            {
                Console.WriteLine(0);
                return;
            }
            if(queue.Contains(X))
                Console.WriteLine("true");
            else
                Console.WriteLine(queue.Min());

        }
    }
}
