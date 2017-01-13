using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');

            List<int> arr = new List<int>();

            foreach (var t in input.Reverse())
            {
                foreach (var p in t.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse))
                {
                    arr.Add(p);
                }    
            }

            Console.WriteLine(string.Join(" ",arr));

            
        }
    }
}
