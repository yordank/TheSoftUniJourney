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
            string str = Console.ReadLine();

            Box<string> box = new Box<string>(str);

            list.Add(box);
        }

        int [] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Swap(indexes[0], indexes[1], list);

        list.ForEach(x => Console.WriteLine(x.ToString()));
    }

    static void Swap<T>(int index1,int index2,List<Box<T>>list)
    {
        Box<T> temp = list[index1];

        list[index1] = list[index2];

        list[index2] = temp;

    }

}

