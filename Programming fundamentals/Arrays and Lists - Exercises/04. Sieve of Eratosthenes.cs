using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];

            for (int k = 0; k <= n; k++)
                primes[k] = true;

            primes[0] = false;
            primes[1] = false;



            for (int p = 2; p <= n; p++)
            {
                int min = 0;
                for (int i = 0; i <= n; i++)
                    if (primes[i] != false)
                    {
                        min = i;
                        break;
                    }
                if (min == 0) break;
                Console.Write($"{min} ");

                for (int i = min; i <= n; i = i + min)
                    primes[i] = false;
            }





        }
    }
}
