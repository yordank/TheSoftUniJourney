using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "print")
            {
                var command = input.Split();

                if (command[0] == "add")
                {
                    array.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }

                if (command[0] == "addMany")
                {
                    List<int> arrayTemp = new List<int>();
                    for (int i = 2; i < command.Length; i++)
                        arrayTemp.Add(int.Parse(command[i]));

                    array.InsertRange(int.Parse(command[1]),arrayTemp);
                }

                if (command[0] == "contains")
                {
                    Console.WriteLine(array.IndexOf(int.Parse(command[1])));
                }

                if (command[0] == "remove")
                {
                    array.RemoveAt(int.Parse(command[1]));
                }
                if (command[0] == "shift")
                {
                    int countShifts = int.Parse(command[1]);

                    for (int i = 0; i < countShifts; i++)
                    {
                        int num = array.ElementAt(0);
                        array.Insert(array.Count(), num);
                        array.RemoveAt(0);
                    }

                }
                if (command[0] == "sumPairs")
                {
                    if (array.Count() % 2 == 1)
                        array.Add(0);

                    int arrayCount = array.Count();
                    
                    for (int i = 0; i < arrayCount / 2; i++)
                    {
                        
                        int number1 = array.ElementAt(0);
                        int number2 = array.ElementAt(1);
                        array.RemoveAt(0);
                        array.RemoveAt(0);
                        array.Add(number1 + number2);
                    }

                }



                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ",array)}]");
        }
    }
}
