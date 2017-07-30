using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        try
        {
            Lake lake = new Lake(input.Split(new char[] { ',',' '},StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList());

            List<int> output = new List<int>();

            foreach (var item in lake)
            {
                output.Add(item);
            }

            Console.WriteLine(string.Join(", ", output));
        }
        catch
        {

        }
    }
}

