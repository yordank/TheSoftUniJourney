using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Problems
{
    public class Problem3
    {
        public static void solution()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentNumber = -1;

            int currentOcccurences = 0;

            int mostFrequentNumber = arr[0];

            int mostOccurences = 1;

            for (int i = 0; i < arr.Length; i++)
            {

                if (currentNumber == arr[i])
                {
                    currentOcccurences++;

                    if (currentOcccurences > mostOccurences)
                    {
                        mostOccurences = currentOcccurences;
                        mostFrequentNumber = currentNumber;
                    }

                }

                else
                {
                    currentNumber = arr[i];
                    currentOcccurences = 1;

                }


            }

            for (int i = 0; i < mostOccurences; i++)
            {
                Console.Write(mostFrequentNumber);
            }
        }
    }
}
