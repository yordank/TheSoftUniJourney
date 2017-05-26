using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>(nums);

            while(stack.Count()>0)
            {
                Console.Write($"{stack.Pop()} ");
            }

        }
    }
}
