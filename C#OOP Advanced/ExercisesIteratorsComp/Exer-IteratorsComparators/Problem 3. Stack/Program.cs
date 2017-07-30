using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {//Sorry I made it before 133249238529 times
        string input;

        Stack<string> stack = new Stack<string>();

        while ((input = Console.ReadLine()) != "END")
        {
            var args = input
                .Split(new char[] { ',',' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();

            switch (args[0])
            {
                case "Push":

                    foreach (var item in args.Skip(1))
                    {
                        stack.Push(item);
                    }

                    break;

                case "Pop":
                    try
                    {
                      stack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("No elements");
                        return;
                    }

                    break;
            }                     

        }

        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

    }
}

