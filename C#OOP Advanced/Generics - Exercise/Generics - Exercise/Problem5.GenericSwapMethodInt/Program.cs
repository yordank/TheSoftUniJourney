using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<Box<int>> list = new List<Box<int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>(num);

            list.Add(box);
        }

        int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Swap(indexes[0], indexes[1], list);

        list.ForEach(x => Console.WriteLine(x.ToString()));
    }

    static void Swap<T>(int index1, int index2, List<Box<T>> list)
    {
        Box<T> temp = list[index1];

        list[index1] = list[index2];

        list[index2] = temp;

    }

}

