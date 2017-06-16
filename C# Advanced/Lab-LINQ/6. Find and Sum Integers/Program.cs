using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Find_and_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var numbers = input.Split(' ')
                .Select(n => {
                    long value;
                    bool success = long.TryParse(n, out value);
                    return new { value, success };
                })
                .Where(b => b.success)
                .Select(x => x.value)
                .ToList();

            if(numbers.Count>0)
                Console.WriteLine(numbers.Sum());
            else
                Console.WriteLine("No match");
        }
    }
}
