using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        string input;

        ListyIterator<string> list=null;

         

        while ((input = Console.ReadLine()) != "END")
        {
            var args = input.Split();

            switch (args[0])
            {
                case "Create":
                    list = new ListyIterator<string>(new List<string>(args.Skip(1)));

                    break;
                case "Move":
                    Console.WriteLine(list.Move());
                    break;
                case "Print":

                    try
                    {
                        list.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "HasNext":

                    Console.WriteLine(list.HasNext());
                    break;
            }


        }
    }
}

