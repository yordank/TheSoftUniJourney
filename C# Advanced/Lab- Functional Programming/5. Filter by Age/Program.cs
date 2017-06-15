using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var people=new Dictionary<string,int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] {","},StringSplitOptions.RemoveEmptyEntries);

                people.Add(input[0],int.Parse(input[1]));
            }

            Func<int, bool> tester = CreateTester(Console.ReadLine(), int.Parse(Console.ReadLine()));


            Action<KeyValuePair<string, int>> printer =CreatePrinter(Console.ReadLine());

            PrintFilteredStudent(people, tester, printer);


        }

        private static void PrintFilteredStudent(Dictionary<string,int> people, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            people.Select(x => x).ToList().Where(x => tester(x.Value)).ToList().ForEach(printer);
        }

        public static Func<int, bool> CreateTester(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return x => x < age;

                case "older": return x => x >= age;

                default: return null;

            }


        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {

                case "name":
                    return person => Console.WriteLine($"{person.Key}");

                case "age":
                    return person => Console.WriteLine($"{person.Value}");

                case "name age":

                    return person => Console.WriteLine($"{person.Key} - {person.Value}");

                default: return null;
            }

        }
    }
}
