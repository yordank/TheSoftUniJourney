using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Opinion_Poll
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var People = new List<Person>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(items[0], int.Parse(items[1]));
                People.Add(person);

            }

            People.Where(x => x.age > 30).OrderBy(x => x.name).ToList().ForEach(x => Console.WriteLine(x.name + " - " + x.age));

        }
    }
}
