using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var setRanges = Console.ReadLine().Split().Select(int.Parse).ToList();

            int n = setRanges[0];

            int m = setRanges[1];

            var set1 = new HashSet<int>();

            var set2 = new HashSet<int>();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());

                set1.Add(num);

            }


            for (int i = 0; i < m; i++)
            {

                int num = int.Parse(Console.ReadLine());


                set2.Add(num);

            }

            set1.IntersectWith(set2);

            foreach (var num in set1)
            {
                Console.Write($"{num} ");
            }

        }
    }
}
