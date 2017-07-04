using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            Family family = new Family();

            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                Person person = new Person()
                {
                    name = input.Split()[0],
                    age = int.Parse(input.Split()[1])
                };

                family.AddMember(person);

            }

            Console.WriteLine(family.GetOldestMember().ToString());

        }
    }
}
