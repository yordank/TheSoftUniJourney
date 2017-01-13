using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse);
            bool flag = false;
            for (int i = 0; i < arr.Count()-1; i++)
            {
                for (int j = i+1; j < arr.Count(); j++)
                {
                    int sum = arr.ElementAt(i) + arr.ElementAt(j);
                    for (int k =0; k < arr.Count(); k++)
                    {
                        if (arr.ElementAt(k) == sum)
                        {
                            Console.WriteLine($"{arr.ElementAt(i)} + {arr.ElementAt(j)} == {arr.ElementAt(k)}");
                            flag = true;
                            break;
                        }
                    }


                }
            }

            if (flag == false)
                Console.WriteLine("No");


        }
    }
}
