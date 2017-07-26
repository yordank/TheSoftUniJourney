using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split().ToList();

        var urls = Console.ReadLine().Split().ToList();

        foreach (var num in nums)
        {
            Smartphone smartphone = new Smartphone();

            smartphone.Call(num);

        }

        foreach (var url in urls)
        {
            Smartphone smartphone = new Smartphone();

            smartphone.Browse(url);

        }

    }

}

