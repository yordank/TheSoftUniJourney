using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = char.Parse(Console.ReadLine());
            char letter3 = char.Parse(Console.ReadLine());

            int count = 0;
            for (int i = (int)letter1; i <= (int)letter2; i++)
            {
                for (int j = (int)letter1; j <= (int)letter2; j++)
                {
                    for (int k = (int)letter1; k <= (int)letter2; k++)
                    {
                        int skipLetter = (int)letter3;
                        if (skipLetter != i && skipLetter != j && skipLetter != k)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                            count++;
                        }
                    }

                }
            }
            Console.Write(count);


        }
    }
}
