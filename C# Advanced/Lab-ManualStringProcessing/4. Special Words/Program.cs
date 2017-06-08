using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Special_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            var words = Console.ReadLine().Split(new char[] {'(', ')', '<', '>', ',', '-', '!', '?', ' '},
                StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var word in words)
            {
                dict.Add(word, 0);
            }

            var input = Console.ReadLine().Split(new char[] { '(', ')', '<', '>', ',', '-', '!', '?', ' ' },
                StringSplitOptions.RemoveEmptyEntries).ToList();


            foreach (var w in input)
            {
                if(dict.ContainsKey(w))
                dict[w]++;
            }

            foreach (var dictElem in dict)
            {
                Console.WriteLine($"{dictElem.Key} - {dictElem.Value}");
            }



        }
    }
}
