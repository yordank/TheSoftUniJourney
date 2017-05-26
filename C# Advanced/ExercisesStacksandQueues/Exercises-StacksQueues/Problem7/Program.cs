using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Select(x => x.ToString()).ToList();

            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] == "(")
                    stack.Push(input[i]);

                if (input[i] == "[")
                    stack.Push(input[i]);

                if (input[i] == "{")
                    stack.Push(input[i]);

                if (input[i] == ")")
                {

                    if (stack.Count() == 0)
                    {
                        Console.WriteLine("NO");
                        return;

                    }

                    string ch = stack.Pop();

                    if (ch != "(")
                    {
                        Console.WriteLine("NO");
                        return;

                    }

                }

                if (input[i] == "]")
                {

                    if (stack.Count() == 0)
                    {
                        Console.WriteLine("NO");
                        return;

                    }

                    string ch = stack.Pop();

                    if (ch != "[")
                    {
                        Console.WriteLine("NO");
                        return;

                    }

                }

                if (input[i] == "}")
                {

                    if(stack.Count()==0)
                    {
                        Console.WriteLine("NO");
                        return;

                    }

                    string ch = stack.Pop();

                    if (ch != "{")
                    {
                        Console.WriteLine("NO");
                        return;

                    }

                }


            }

            if (stack.Count() == 0)
                Console.WriteLine("YES");

        }

    }
}
