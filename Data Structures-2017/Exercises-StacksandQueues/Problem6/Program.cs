using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        class Node<T>
        {
            public Node()
            {
                this.Prev = null;
            }

            public Node(T value)
            {
                this.value = value;

                Prev = null;

            }


            public Node(T value,Node<T>node)
            {

                this.value = value;

                this.Prev = node;

            }


            public T value { get; set; }

            public Node<T> Prev { get; set; }



        }
        static void Main(string[] args)
        {
            Queue<Node<int>> q = new Queue<Node<int>>();

            var input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);

            int m = int.Parse(input[1]);

            Node<int> newNode = new Node<int>(n);

            q.Enqueue(newNode);

            while (q.Count != 0)
            {
                Node<int> node = q.Dequeue();

                if (node.value < m)
                {
                    q.Enqueue(new Node<int>(node.value + 1, node));
                    q.Enqueue(new Node<int>(node.value + 2, node));
                    q.Enqueue(new Node<int>(node.value * 2, node));

                }

                if (node.value == m)
                {
                    PrintSolution(node);
                    return;
                }

            }


        }

        private static void PrintSolution(Node<int> node)
        {
            Node<int> nd = node;

            Stack<int> stack = new Stack<int>();

            while (nd != null)
            {

                stack.Push(nd.value);

                nd = nd.Prev;

            }

            if(stack.Count()==0)
                Console.WriteLine("(no solution)");

            Console.WriteLine($"{string.Join(" -> ",stack)}");


        }
    }
}
