using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10.StudentGroups
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredDate { get; set; }
    }
    class Town
    {
        public string Name { get; set; }
        public int SetCount { get; set; }
        public List<Student> students { get; set; }
    }
    class Group
    {
        public Town town { get; set; }
        public List<Student>students{ get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = ReadsTownsAndStudents();
            List<Group> groups = DistributeStudentsIntoGroups(towns);

            print(groups);

        }

        private static void print(List<Group> groups)
        {
            Console.WriteLine($"Created {groups.Count} groups in {groups.Select(x=>x.town).Distinct().Count()} towns:");

            var t = groups.OrderBy(x => x.town);
            foreach (var item in groups)
            {
                Console.WriteLine($"{item.town.Name} => {string.Join(", ",item.students.Select(x=>x.Email).ToList())}");
            }
        }

        static List<Group> DistributeStudentsIntoGroups(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (var town in towns.OrderBy(x=>x.Name))
            {
                IEnumerable<Student> students = town.students.
                    OrderBy(x => x.RegisteredDate).
                    ThenBy(x => x.Name).
                    ThenBy(x => x.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.town = town;
                    group.students = students.Take(group.town.SetCount).ToList();
                    students = students.Skip(group.town.SetCount);
                    groups.Add(group);

                }
            }


            return groups;
        }


        static List<Town> ReadsTownsAndStudents()
        {
            var towns = new List<Town>();
            var input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    Town town = new Town();
                    input = input.Replace(" => ", ",");
                    var townNameCount = input.Split(',');
                    town.Name = townNameCount[0];
                    town.SetCount = int.Parse(townNameCount[1].Split()[0]);
                    town.students = new List<Student>();
                    towns.Add(town);
                }
                else
                {
                    Town town = towns.Last();
                    List<Student> newStudents = town.students;

                    Student student = new Student();
                    var StudentsNameEmailDate = input.Split('|');

                    student.Name = StudentsNameEmailDate[0];
                    student.Email = StudentsNameEmailDate[1].Replace(" ", "");
                    student.RegisteredDate = DateTime.ParseExact(StudentsNameEmailDate[2].Replace(" ",""), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    newStudents.Add(student);

                    
                     
                }

                input = Console.ReadLine();

            }
             

            return towns;
        }
    }
}
