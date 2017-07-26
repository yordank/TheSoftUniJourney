using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


public class Smartphone : ICallable, IBrowseble
{
    public void Browse(string url)
    {
        if (Regex.IsMatch(url, "\\d"))
        {
            Console.WriteLine("Invalid URL!");
        }
        else
        {
            Console.WriteLine($"Browsing: {url}!");
        }

    }

    public void Call(string number)
    {
        if (!Regex.IsMatch(number, "^\\d+$"))
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            Console.WriteLine($"Calling... {number}");
        }


    }
}

