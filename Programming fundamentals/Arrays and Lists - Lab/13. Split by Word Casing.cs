using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' },StringSplitOptions.RemoveEmptyEntries);

            List<string> UpperList = new List<string>();
            List<string> LowerList = new List<string>();
            List<string> MixedList = new List<string>();

            foreach (var t in input)
            {
                int lenUpperLetter = 0;
                int lenLowerLetter = 0;

                for (int i = 0; i < t.Length; i++)
                {
                    if (t[i] >= 'A' && t[i] <= 'Z')
                        lenUpperLetter++;
                    if (t[i] >= 'a' && t[i] <= 'z')
                        lenLowerLetter++;
                }

                if (lenUpperLetter == t.Length)
                    UpperList.Add(t);
                else if (lenLowerLetter == t.Length)
                    LowerList.Add(t);
                else
                    MixedList.Add(t);


            }

            Console.WriteLine($"Lower-case: {string.Join(", ", LowerList)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", MixedList)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", UpperList)}");

        }
    }
}
