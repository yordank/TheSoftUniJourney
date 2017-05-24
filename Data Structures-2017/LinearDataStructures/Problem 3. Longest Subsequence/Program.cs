using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Longest_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int bestCount = 1;

            int currentCount = 1;

            int bestBegin = 0;

            int currentBegin = 0;

           
            for (int i = 0; i < input.Count()-1; i++)
            {

                if(input[i]==input[i+1])
                {
                    currentCount++;

                    if (currentCount>bestCount)
                    {
                        bestCount = currentCount;
                        bestBegin = currentBegin;
                        
                    }

                }

                else
                {
                    currentBegin = i+1;
                    currentCount = 1;
                }


            }

            Console.WriteLine($"{string.Join(" ",input.Skip(bestBegin).Take(bestCount))}");

        }

    }
}
