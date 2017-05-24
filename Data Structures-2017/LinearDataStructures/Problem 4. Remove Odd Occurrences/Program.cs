using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Remove_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            Dictionary<int, int> histogram = new Dictionary<int, int>();

            for (int i = 0; i < input.Count(); i++)
            {
                if (!histogram.ContainsKey(input[i]))
                    histogram.Add(input[i], 0);

                histogram[input[i]]++;
            }

            for (int i = 0; i < input.Count(); i++)
            {

                if(histogram[input[i]]%2==0)
                {
                    Console.Write($"{input[i]} ");
                }

            }

        }
    }
}
