using LinkedQueue;
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
            LinkedQueue<int> q = new LinkedQueue<int>();

            q.Enqueue(1);

            q.Enqueue(2);

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
         //   Console.WriteLine(q.Dequeue());

        }
    }
}
