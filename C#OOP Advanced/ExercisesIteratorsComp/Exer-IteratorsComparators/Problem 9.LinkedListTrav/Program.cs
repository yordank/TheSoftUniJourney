using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    static void Main()
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Add")
            {
                linkedList.AddLast(int.Parse(args[1]));
            }
            if (args[0] == "Remove")
            {
                linkedList.Remove(int.Parse(args[1]));
            }

        }


        Console.WriteLine(linkedList.Count);

        foreach (var item in linkedList)
        {
            Console.Write(item);
            Console.Write(" ");
        }
    }
}
