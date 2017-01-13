using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var input = Console.ReadLine().Split('.','!','?');

            foreach (var t in input)
            {
                string h=t;

                for (int i = 0; i < h.Length; i++)
                    if (((h[i] >= 'A' && h[i] <= 'Z')|| !(h[i] >= 'a' && h[i] <= 'z')))
                    {
                        h = h.Replace(h[i],' ');
                       
                    }


               
                var s = h.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                foreach (var q in s)
                {
                     if (q == word)
                     {
                         Console.WriteLine(t);
                         break;
                     }

                    
                }

            }

        }
    }
}
