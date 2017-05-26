using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Queue<long> q = new Queue<long>();

            q.Enqueue(num);

            for (long i = 0; i < 50; i++)
            {
                long n = q.Dequeue();

                Console.Write(n+" ");

                q.Enqueue(n + 1);

                q.Enqueue(2 * n + 1);

                q.Enqueue(n + 2);



            }

           



        }
    }
}
