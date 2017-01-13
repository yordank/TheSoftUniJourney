using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ','?','.',',','!',':',';');
            List<string> a = new List<string>();

            foreach (var t in input)
            {
                int len = t.Length/2;

                string sub1 = t.Substring(0, len);

              //  Console.WriteLine(sub1);
                string sub2 = "";

               if (t.Length%2==0)
                    sub2 = t.Substring(len, len);
                //   Console.WriteLine(sub2);
                if (t.Length % 2 == 1)
                    sub2 = t.Substring(len+1, len);

                var d = sub2.ToCharArray().Reverse();
                var f = string.Join("",d);

                if (sub1==f && t.Length>0)
                {
                    //(a.Find(g=>g=t))
                    a.Add(t);
                   // a.Distinct();
                }

            }
           var m= a.Distinct().ToList();
            m.Sort();
            Console.Write(string.Join(", ", m));

        }
    }
}
