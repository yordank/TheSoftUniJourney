using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Company_Roster
{
    class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string department;
        public string email;
        public int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var Employees = new List<Employee>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                Employee empl = new Employee(items[0], decimal.Parse(items[1]), items[2], items[3]);

                if (items.Length == 6)
                {

                    empl.email = items[4];
                    empl.age = int.Parse(items[5]);


                }

                if (items.Length == 5)
                {
                    if (items[4].Contains("@"))
                    {
                        empl.email = items[4];
                    }
                    else
                    {
                        empl.age = int.Parse(items[4]);
                    }

                }

                Employees.Add(empl);

            }

            var res = Employees.GroupBy(x => x.department).OrderByDescending(x => x.Average(y => y.salary)).ToList();


            foreach (var item in res.Take(1))
            {
                Console.WriteLine($"Highest Average Salary: {item.Key}");
                foreach (var item1 in item.OrderByDescending(x => x.salary))
                {
                    Console.WriteLine($"{item1.name} {item1.salary:f2} {item1.email} {item1.age}");
                }
            }



        }
    }
}
