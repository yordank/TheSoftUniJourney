using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Tower_of_Hanoi
{
    class Program
    {
        private static int stepsTaken = 0;

        private static Stack<int> source;

        private static readonly Stack<int> destination = new Stack<int>();

        private static readonly Stack<int> spare = new Stack<int>();

        static void Main(string[] args)
        {
            int numberOfDisks = int.Parse(Console.ReadLine());
            var range = Enumerable.Range(1, numberOfDisks);
            source = new Stack<int>(Enumerable.Range(1, numberOfDisks).Reverse());
            PrintRods();
            MoveDisks(numberOfDisks, source, spare,destination);
        }

        private static void PrintRods()
        {
            Console.WriteLine("Source: {0}",string.Join(", ",source.Reverse()));

            Console.WriteLine("Destination: {0}",string.Join(", ",destination.Reverse()));

            Console.WriteLine("Spare: {0}",string.Join(", ",spare.Reverse()));

            Console.WriteLine();
        }

        private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> spare, Stack<int> destination)
        {
            if(bottomDisk==1)
            {
                stepsTaken++;
                destination.Push(source.Pop());
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintRods();
                
            }
            else
            {
                MoveDisks(bottomDisk - 1, source, destination, spare);

                destination.Push(source.Pop());

                stepsTaken++;
                Console.WriteLine($"Step #{stepsTaken}: Moved disk");
                PrintRods();

                MoveDisks(bottomDisk - 1, spare,source, destination);

            }

        }


    }

}
