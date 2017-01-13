using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            switch (type)
            {
                case "int":Console.WriteLine(GetMax(int.Parse(first), int.Parse(second)));break;
                case "char": Console.WriteLine(GetMax(char.Parse(first), char.Parse(second))); break;
                case "string": Console.WriteLine(GetMax(first,second)); break;
            }

        }

        static int GetMax(int first, int second)
        {
            if (first >= second)
                return first;
            return second;
        }

        static char GetMax(char first,char second)
        {
            if (first >= second)
                return first;
            return second;
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second)>=0)
                return first;
            return second;
        }


    }
}
