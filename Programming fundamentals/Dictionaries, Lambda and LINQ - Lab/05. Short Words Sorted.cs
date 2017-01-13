using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().ToLower().Split(' ',',','.','?','!');
            IEnumerable<string >arr=  str.Where(x => x.Length < 5&&x.Length>=1).Distinct().OrderBy(x=>x);
            Console.WriteLine(string.Join(", ",arr));

        }
    }
}
