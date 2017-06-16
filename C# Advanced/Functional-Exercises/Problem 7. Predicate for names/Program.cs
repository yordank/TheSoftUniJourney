using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Predicate_for_names
{
    class Program
    {
        static void Main(string[] args)
        {

            var num = int.Parse(Console.ReadLine());


            Predicate<string> pred = (x => x.Length <= num);

            var names = Console.ReadLine().Split().ToList();

            names.Where(x => pred(x)).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
