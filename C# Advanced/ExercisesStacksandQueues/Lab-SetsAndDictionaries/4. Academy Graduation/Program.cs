using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Academy_Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, List<double>> dict = new SortedDictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {

                var Name = Console.ReadLine();

                var marks = Console.ReadLine().Trim().Split(new char[] {' ' },StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

                dict.Add(Name, marks);


            }


            foreach (var dictElem in dict.OrderBy(x=>x.Key).ThenBy(x=>x.Value.Average()))
            {
                Console.WriteLine($"{dictElem.Key} is graduated with {dictElem.Value.Average()}");
            }


        }
    }
}
