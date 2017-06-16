using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> odd = (int num) =>
            {
                return num % 2 !=0 ;
            };

            Predicate<int> even = (int num) =>
            {
                return num % 2 == 0;
            };

            var input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var command = Console.ReadLine();

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (command=="odd" && odd(i))
                    Console.Write($"{i} ");

                if (command == "even" && even(i))
                    Console.Write($"{i} ");





            }


        }
    }
}
