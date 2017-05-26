using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Potato
{
    class Program
    {
  
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            int number = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>(input.Split().ToList());

            //TODO: Read input from console
            int cycle = 1;

            while (queue.Count != 1)
            {
                for (int i = 1; i < number; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }

                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");

        }

        private static bool IsPrime(int cycle)
        {
            if (cycle == 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(cycle); i++)
            {
                if (cycle % i == 0)
                    return false;
            }

            return true;
        }
    }
}
