using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int courses = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((decimal)courses / people));

        }
    }
}
