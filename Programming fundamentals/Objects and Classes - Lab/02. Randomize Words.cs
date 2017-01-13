using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomNumber=rnd.Next(0, words.Length);

                string tempValue = words[i];
                words[i] = words[randomNumber];
                words[randomNumber] = tempValue;
            

            }

            Console.WriteLine(string.Join("\n", words));

        }
    }
}
