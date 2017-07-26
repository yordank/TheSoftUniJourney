using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int num = 123;
        Box<int> box1 = new Box<int>(num);
        Console.WriteLine(box1.ToString());

        string str = "life in a box";
        Box<string> box2 = new Box<string>(str);
        Console.WriteLine(box2.ToString());
    }
}

