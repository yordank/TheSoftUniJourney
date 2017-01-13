using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} -> {isspecial(i)}");
                    
            }


        }

        private static bool isspecial(int num)
        {
            int sum = 0;
            while (num >= 10)
            {
                sum += num % 10;
                num = num / 10;
            }
            sum += num % 10;

            if (sum == 5 || sum == 7 || sum == 11)
                return true;
            else
                return false;
        }

    }
}
