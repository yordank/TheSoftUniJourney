using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        CustomList<string> customList = new CustomList<string>();

        string line;

        while ((line = Console.ReadLine()) != "END")
        {
            var args = line.Trim().Split();

            switch (args[0])
            {
                case "Add":
                    customList.Add(args[1]);
                    break;
                case "Remove":
                    customList.Remove(int.Parse(args[1]));
                    break;
                case "Contains":
                    Console.WriteLine(customList.Contains(args[1]));
                    break;
                case "Swap":
                    customList.Swap(int.Parse(args[1]), int.Parse(args[2]));
                    break;
                case "Greater":
                    Console.WriteLine(customList.CountGreaterThan(args[1]));
                    break;
                case "Max":
                    Console.WriteLine(customList.Max());
                    break;
                case "Min":
                    Console.WriteLine(customList.Min());
                    break;
                case "Sort":
                    Sorter<string>.Sort(customList);
                    break;
                case "Print":
                    foreach (var item in customList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }


        }
    }
}

