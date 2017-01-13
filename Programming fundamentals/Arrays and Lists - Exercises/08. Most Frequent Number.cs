using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = 0;
            int max = 0;
            int ind = 0;
            for (int i = 0; i < arr.Count(); i++)
            { for (int j = i; j < arr.Count(); j++)
                {
                    if (arr[i] == arr[j]) count++;
                }
                if (count > max)
                {
                    max = count;
                    ind = i;
                }
                count = 0;
            }

            Console.WriteLine(arr[ind]);

        }
    }
}
