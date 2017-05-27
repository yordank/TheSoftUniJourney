using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int> q = new Queue<int>();

            q.Enqueue(n);

            List<int> results = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                int num = q.Dequeue();
                results.Add(num);
                q.Enqueue(num + 1);
                q.Enqueue(2 * num + 1);
                q.Enqueue(num + 2);
            }


            Console.WriteLine($"{string.Join(", ",results)}");

        }
    }
}
