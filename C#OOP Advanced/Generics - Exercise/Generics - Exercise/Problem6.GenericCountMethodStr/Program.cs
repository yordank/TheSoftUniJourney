using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Box<string>> list = new List<Box<string>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string elem = Console.ReadLine();

            Box<string> box = new Box<string>(elem);

            list.Add(box);
        }

        string elemCompared = Console.ReadLine();

        Console.WriteLine(CountGreaterThenValue<string>(list, elemCompared));

    }

    static int CountGreaterThenValue<T>(List<Box<T>> list, T elem)
        where T : IComparable
    {
        int count = 0;

        foreach (var listElem in list)
        {
            if (listElem.Value.CompareTo(elem) > 0)
                count++;
        }

        return count;
    }
}

