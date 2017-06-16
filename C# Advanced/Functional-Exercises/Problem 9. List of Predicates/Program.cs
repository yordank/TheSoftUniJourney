using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var nums = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            

            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= n; i++)
            {
                 

                bool flag = true;

                foreach (var divider in nums)
                {
                    Func<int, int, bool> pred = (x, y) => x % y == 0;

                    if (!pred(i,divider))
                    {
                        flag = false;
                        break;
                    }



                }
                if(flag)
                sb.Append(i + " ");


            }

            Console.WriteLine(sb);


        }
    }
}
