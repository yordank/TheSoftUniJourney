using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.First_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();

            var letters= Console.ReadLine().Split().ToList();

            string name = String.Empty;

            foreach (var letter in letters.OrderBy(x=>x))
            {
                name = names.Where(w => w.ToLower()
                        .StartsWith(letter.ToLower()))
                    .FirstOrDefault();
                if (name != null)
                {
                    Console.WriteLine(name);
                    break;
                }
            }
            if (name == null) Console.WriteLine("No match");

        }
    }
}
