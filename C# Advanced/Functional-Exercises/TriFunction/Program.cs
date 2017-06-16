using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split().ToList();



            Func<string, int> func = SumOfCharacters;

            Func<Func<string,int>,string,int> func1= TriFunc;

            foreach (var name in names)
            {
                if (TriFunc(func,name)>n)
                {
                    Console.WriteLine(name);
                    return;
                }
            }

        }

        private static int TriFunc(Func<string, int> func,string str )
        {
            return func(str);
        }

        private static int SumOfCharacters(string str)
        {
            int count = 0;

            for (int i = 0; i < str.Length; i++)
            {
                count += str[i];
            }

            return count;
        }

    }
}
