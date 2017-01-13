using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Magic_exchangeable_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Console.WriteLine(isExchangenble(input[0],input[1]).ToString().ToLower());


        }
        static bool isExchangenble(string a, string b)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            int len = Math.Min(a.Length, b.Length);

            for (int i = 0; i < len; i++)
            {
                char ch = a[i];
                 
                if (!dict.ContainsKey(ch))
                {
                    dict.Add(ch, b[i]);
                }
                else
                {
                    if (dict[ch] != b[i])
                        return false;
                }


            }

            if (a.Length != b.Length)
            {
                if (a.Distinct().Count() != b.Distinct().Count())
                    return false;
            }

            return true;
        }
    }
}
