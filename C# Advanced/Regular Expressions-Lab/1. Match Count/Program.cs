using System;
using System.Text.RegularExpressions;

namespace _1.Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            Regex Regex = new Regex(pattern);

            int count = Regex.Matches(text).Count;

            Console.WriteLine(count);
        }
    }
}
