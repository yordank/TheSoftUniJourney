using System;
using System.Linq;

namespace Problem_5.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                switch (input)
                {
                    case "add": nums= nums.Select(x=>x+1).ToList();break;
                    case "multiply": nums = nums.Select(x => x *2).ToList(); break;
                    case "subtract": nums = nums.Select(x => x - 1).ToList(); break;
                    case "print": Console.WriteLine(string.Join(" ", nums)); break;
                }
                input = Console.ReadLine();
            }


           

        }
    }
}
