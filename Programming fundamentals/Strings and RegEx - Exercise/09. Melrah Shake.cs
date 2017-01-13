using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();

            
            string before = input;
            while (CountMatches(input, pattern) >= 2 && pattern!="")
            {
                input = RemoveMatch(input, pattern);
                input = string.Join("",input.ToCharArray().Reverse().ToArray());
                input = RemoveMatch(input, string.Join("",pattern.ToCharArray().Reverse().ToArray()));
                input = string.Join("", input.ToCharArray().Reverse().ToArray());

                if(before==input)
                    Console.WriteLine("No shake.");
                else
                    Console.WriteLine("Shaked it.");

                pattern=pattern.Remove(pattern.Length / 2,1);
            }
            Console.WriteLine("No shake.");
            
            Console.WriteLine(input);
        }
        static int CountMatches(string input, string pattern)
        {
            int index = 0;
            int count = 0;
            while (index<input.Length&&index!=-1)
            {
                index = input.IndexOf(pattern,index);
                
                if (index != -1)
                {
                    index++;
                    count++;
                }
            }
            return count;
        }

        static string RemoveMatch(string input, string pattern)
        {
            int index = input.IndexOf(pattern, 0);
            if (index != -1)
            {
                return input.Substring(0, index) + input.Substring(index + pattern.Length);
            }

            return input;
        }
    }
}
