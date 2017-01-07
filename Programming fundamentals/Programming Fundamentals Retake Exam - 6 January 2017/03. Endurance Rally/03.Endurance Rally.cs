using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();

            var array = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < names.Count(); i++)
            {
                decimal start = (decimal)names[i][0];

                decimal fuel = start;

                int ind = 0;

                int flag = 0;

                while(ind<array.Count())
                {
                    if (indexes.Where(x => x == ind).Count() == 0)
                        fuel -= array[ind];
                    else
                        fuel += array[ind];
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{names[i]} - reached {ind}");
                        flag = 1;
                        break;
                    }

                    ind++;

                }

                if(flag==0)
                Console.WriteLine($"{names[i]} - fuel left {fuel:f2}");

            }

        }
    }
}
