using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray().Select(int.Parse);

            int best = 0;
            int start = 0;
            int end = 0;
            int flag = 0;
           
            for (int i = 0; i < arr.Count()-1; i++)
                for (int j = i; j < arr.Count(); j++)
                {
                    //Console.WriteLine($"{i}{j}");
                    int count = 0;
                    int k = i;
                    for ( k = i; k <= j-1; k++)
                    {
                        if (arr.ElementAt(k) >= arr.ElementAt(k+1))
                            flag = 1;
                        count++;
                    }

                    if (flag == 0)
                    {
                        if (best < count)
                        {
                            best = count;
                            start = i;
                            end = j;
                        }
                    }

                    flag = 0;
                }

            for (int i = start; i <= end; i++)
            {
               Console.Write($"{arr.ElementAt(i)} ");
            }

        }
    }
}
