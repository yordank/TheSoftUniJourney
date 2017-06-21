using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Sweep_and_Prune
{
    class Program
    {
        static void Main(string[] args)
        {

            



            var items = new List<Item>();
            var byId = new Dictionary<string, Item>();


            var running = true;
            var ticks = 0;
            var line = Console.ReadLine();

            while (!line.Equals("end"))
            {
                var cmdArgs = line.Split();

                switch (cmdArgs[0])
                {
                    case "add":
                        AddItem(items, byId, cmdArgs);
                        break;
                    case "start":
                        while (running)
                        {
                            line = Console.ReadLine();
                            cmdArgs = line.Split();

                            if (cmdArgs[0].Equals("end"))
                            {
                                running = false;
                                return;
                            }
                            if (cmdArgs[0].Equals("move"))
                            {
                                var id = cmdArgs[1];
                                var x = int.Parse(cmdArgs[2]);
                                var y = int.Parse(cmdArgs[3]);
                                byId[id].X1 = x;
                                byId[id].Y1 = y;
                            }
                            

                            Sweep(++ticks, items);

                        }
                        break;
                    default:
                        break;

                }
                line = Console.ReadLine();

            }
        }

        private static void Sweep(int ticks, List<Item> items)
        {
            InsertionSort(items);

            for (int i = 0; i < items.Count; i++)
            {
                var current = items[i];

                for (int j = i+1; j < items.Count; j++)
                {

                    var candidate = items[j];

                    if (candidate.X1 > current.X2)
                    {
                        break;
                    }

                    if (current.Intersect(candidate))
                    {
                        Console.WriteLine("({0}) {1} collides with {2}", ticks,current.Id,candidate.Id);    
                    }   
                     
                }

            }

        }

        private static void InsertionSort(List<Item> items)
        {
            for (int i = 1; i < items.Count; i++)
            {
                var j = i;
                while (j > 0 && items[j-1].X1>items[j].X1)
                {
                    Swap(j - 1, j, items);
                    j--;
                }
            }
        }

        private static void Swap(int i, int j, List<Item> items)
        {
            var temp = items[i];
            items[i] = items[j];
            items[j] = temp;
        }

        private static void AddItem(List<Item> items, Dictionary<string, Item> byId, string[] cmdArgs)
        {
            var id = cmdArgs[1];
            var x = int.Parse(cmdArgs[2]);
            var y = int.Parse(cmdArgs[3]);
            var item = new Item(id, x, y);
            items.Add(item);
            byId[id] = item;
        }
    }
}
