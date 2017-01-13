using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string substring = Console.ReadLine().ToLower();
            int start = 0;
            int count = 0;

            while ((start=text.IndexOf(substring,start))!=-1)
            {
                start++;
                count++;
            }
            
            Console.WriteLine(count);

        }
    }
}
