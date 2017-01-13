using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Longest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] indexArray1 = new int[array.Length];
            int[] indexArray2 = new int[array.Length];

            for (int i = 0; i < indexArray1.Length; i++)
                indexArray1[i] = 1;

            for (int i = 0; i < indexArray2.Length; i++)
                indexArray2[i] = i;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j] < array[i])
                    {

                       
                        if (indexArray1[j] + 1 > indexArray1[i])
                        {
                            indexArray1[i] = Math.Max(indexArray1[i], indexArray1[j] + 1);
                            indexArray2[i] = j;
                        }
                    }
                }

            }
            
            


            int index = 0;

            for (int i = 0; i <indexArray1.Length; i++)
            {
                if (indexArray1[i] == indexArray1.Max())
                {
                    index = i;
                    break;
                }
            }

            List<int> p = new List<int>();

            while(index!=indexArray2[index])
            {
                p.Add(index);
                index = indexArray2[index];    
            }

            p.Add(index);
            p.Reverse();
            foreach (var t in p)
            {
                Console.Write($"{array[t]} ");
            } 


        }
    }
}
