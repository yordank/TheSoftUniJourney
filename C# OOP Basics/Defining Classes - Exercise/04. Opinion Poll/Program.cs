using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Opinion_Poll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> People = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split();

                Person person = new Person()
                {
                    name=items[0],
                    age=int.Parse(items[1])
                };

                People.Add(person);
            }

            Console.WriteLine(string.Join("\n",People.Where(x=>x.age>30).OrderBy(x=>x.name)));


        }
    }
}
