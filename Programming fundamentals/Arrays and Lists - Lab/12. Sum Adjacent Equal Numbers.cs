using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> array = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            int flag = 0;
            while (flag == 0)
            {
                flag = 1;

                for (int i = 0; i < array.Count-1; i++)
                {
                    if (array[i] == array[i+1])
                        {
                        array[i] *= 2;
                        array.RemoveAt(i + 1);
                        flag = 0;
                        break;
                        }

                }

            }

            Console.WriteLine(string.Join(" ",array));


        }
    }
}
