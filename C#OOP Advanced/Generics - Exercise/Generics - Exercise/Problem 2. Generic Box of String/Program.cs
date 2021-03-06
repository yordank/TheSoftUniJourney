﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            Box<string> box = new Box<string>(str);
            sb.AppendLine(box.ToString());
        }

        Console.WriteLine(sb.ToString());
    }
}

