using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int startPos = 0;
            int endPos = 0;
            int len = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    len++;

                    if(i==arr.Length-1)
                    if (len > endPos - startPos)
                    {
                        startPos = i - len+1;
                        endPos = i+1;
                    }

                }
                else
                {
                    if (len > endPos-startPos)
                    {
                        startPos = i - len;
                        endPos = i;
                    }

                    len = 1;
                    
                }

             


            }

            for (int i = startPos; i < endPos; i++)
                Console.Write($"{arr[i]} ");


        }
    }
}
