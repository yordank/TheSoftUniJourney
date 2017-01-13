using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var BanList = Console.ReadLine().Replace(", ", ",").Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();

            foreach (var item in BanList)
            {
                input = input.Replace(item, new string('*', item.Count()));
            }
            Console.WriteLine(input);

        }
    }
}
