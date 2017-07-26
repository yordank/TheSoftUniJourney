using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Box<double>> list = new List<Box<double>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            double elem =double.Parse(Console.ReadLine());

            Box<double> box = new Box<double>(elem);

            list.Add(box);
        }

        double elemCompared =double.Parse(Console.ReadLine());

        Console.WriteLine(CountGreaterThenValue<double>(list, elemCompared));

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

