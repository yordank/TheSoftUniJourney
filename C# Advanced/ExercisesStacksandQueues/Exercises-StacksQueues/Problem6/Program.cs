using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Node
    {
        public int Index { get; set; }
        public int Distance { get; set; }
        public int AmountOfPetrol { get; set; }

    }
    class Program
    {

        
        static void Main(string[] args)
        {
            Queue<Node> q = new Queue<Node>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToList();

                Node node = new Node()
                {
                    AmountOfPetrol = input[0],
                    Distance = input[1],
                    Index = i
                };

                q.Enqueue(node);
               

            }
            int a = 5;
            for (int i = 0; i < q.Count; i++)
            {
                if(checkIfCanReachFromCurrentNode(q))
                {
                    Console.WriteLine(i);
                    return;
                }

                Node d = q.Dequeue();

                q.Enqueue(d);


            }
            



        }

        static bool checkIfCanReachFromCurrentNode(Queue<Node>queue)
        {
            int totalAmountOfPetrol = 0;

            Queue<Node> q = new Queue<Node>(queue);

            int n = q.Count();

            int i = 0;

            while (i<n)
            {
                i++;

                Node d=q.Dequeue();

                q.Enqueue(d);

                totalAmountOfPetrol -= d.Distance;

                totalAmountOfPetrol += d.AmountOfPetrol;

                if (totalAmountOfPetrol < 0)
                    return false;

                //Distance = d.Distance;



            }


                return true;

        }

    }



}
