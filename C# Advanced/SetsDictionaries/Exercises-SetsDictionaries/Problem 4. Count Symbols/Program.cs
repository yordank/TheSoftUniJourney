using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < input.Count(); i++)
            {
                char ch = input[i];

                if (dict.ContainsKey(ch))
                {
                    dict[ch]++;
                }
                else
                {
                    dict.Add(ch, 1);
                }


            }

            foreach (var dictElem in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{dictElem.Key}: {dictElem.Value} time/s");
            }


        }
    }
}
