using System;
using System.Text.RegularExpressions;

namespace _2.Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex("[AEIOUYaeiouy]");

            int count = regex.Matches(text).Count;

            Console.WriteLine($"Vowels: {count}");
        }
    }
}
