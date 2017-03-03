using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise_Introduction_to_EntityFramework
{
    class Startup
    {
        static void Main(string[] args)
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");

            SoftUniContext context = new SoftUniContext();

            //_3_EmployeesFullInformation(context);

            //_4_Employees_with_Salary_Over_50000(context);

            //_5_Employees_from_Research_and_Development(context);

            //_6_Adding_a_New_Address_and_Updating_Employee(context);

            //_7_Find_Employees_in_Period(context);

            //_8_Addresses_by_Town_Name(context);

            //_9_Employee_with_id_147(context);

            //_10_Departments_with_more_than_5_employees(context);

            //_11_Find_Latest_10_Projects(context);

            //_12_Increase_Salaries(context);

            //_13_Find_Employees_by_First_Name_starting_with_SA(context);

            //_14_First_Letter();

            //_15_Delete_Project_by_Id(context);

        }

        private static void _14_First_Letter()
        {
            GringottsContext contextGringotts = new GringottsContext();

            string output14 = "";

            var letters = contextGringotts.WizzardDeposits.Where(x => x.DepositGroup == "Troll Chest").ToList().Select(y => y.FirstName[0]).Distinct().OrderBy(x => x);

            output14 += $"{string.Join("\r\n", letters)}";

            File.WriteAllText("output14.txt", output14);
        }

        private static void _15_Delete_Project_by_Id(SoftUniContext context)
        {
            var project = context.Projects.Find(2);

            var empl = context.Employees.Where(x => x.Projects.Where(y => y.ProjectID == 2).FirstOrDefault().ProjectID == 2);

            foreach (var e in empl)
            {
                e.Projects.Remove(project);
            }

            context.Projects.Remove(project);

            context.SaveChanges();


            string output15 = "";

            foreach (var p in context.Projects.ToList().Take(10))
            {
                output15 += $"{p.Name}\r\n";
            }

            File.WriteAllText("output15.txt", output15);
        }

        private static void _13_Find_Employees_by_First_Name_starting_with_SA(SoftUniContext context)
        {
            var empl = context.Employees.Where(x => x.FirstName.ToLower().StartsWith("sa")).ToList();

            string output13 = "";

            foreach (var e in empl)
            {
                output13 += $"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary})\r\n";
            }

            File.WriteAllText("output13.txt", output13);
        }

        private static void _12_Increase_Salaries(SoftUniContext context)
        {
            var empl = context.Employees.Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design" || x.Department.Name == "Marketing" || x.Department.Name == "Information Services");

            foreach (var e in empl)
            {
                e.Salary *= 1.12M;
            }
            context.SaveChanges();

            string output12 = "";

            foreach (var e in empl)
            {
                output12 += $"{e.FirstName} {e.LastName} (${e.Salary:F6})\r\n";
            }

            File.WriteAllText("output12.txt", output12);
        }

        private static void _11_Find_Latest_10_Projects(SoftUniContext context)
        {
            var projects = context.Projects.OrderByDescending(x => x.StartDate).ToList().Take(10);

            string output11 = "";

            foreach (var p in projects.OrderBy(x => x.Name))
            {

                string endDate = (p.EndDate == null) ? "" : p.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt");

                output11 += $"{p.Name} {p.Description} {p.StartDate.ToString("M/d/yyyy h:mm:ss tt")} {endDate}\r\n";
            }

            File.WriteAllText("output11.txt", output11);
        }

        private static void _10_Departments_with_more_than_5_employees(SoftUniContext context)
        {
            var dep = context.Departments.Where(x => x.Employees.Count() > 5).OrderBy(x => x.Employees.Count());

            string output10 = "";

            foreach (var d in dep)
            {
                output10 += $"{d.Name} {d.Employee.FirstName}\r\n";

                foreach (var e in d.Employees)
                {
                    output10 += $"{e.FirstName} {e.LastName} {e.JobTitle}\r\n";
                }
            }

            File.WriteAllText("output10.txt", output10);
        }

        private static void _9_Employee_with_id_147(SoftUniContext context)
        {
            Employee empl = context.Employees.Where(x => x.EmployeeID == 147).FirstOrDefault();

            string output9 = "";

            output9 = $"{empl.FirstName} {empl.LastName} {empl.JobTitle}\r\n";


            foreach (var project in empl.Projects.OrderBy(x => x.Name
            ))
            {
                output9 += $"{project.Name}\r\n";
            }

            File.WriteAllText("output9.txt", output9);
        }

        private static void _8_Addresses_by_Town_Name(SoftUniContext context)
        {
            var addr = context.Addresses.ToList();

            string output = "";

            foreach (var a in addr.OrderByDescending(x => x.Employees.Count()).ThenByDescending(x => x.AddressText.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)[0]).Take(10))
            {

                output += $"{a.AddressText}, {a.Town.Name} - {a.Employees.Count()} employees\r\n";

            }

            File.WriteAllText("output8.txt", output);
        }

        private static void _7_Find_Employees_in_Period(SoftUniContext context)
        {
            var emp = context.Employees.Where(x => x.Projects.Select(x1 => x1.StartDate.Year).Any(d => d >= 2001 && d <= 2003)).Take(30);

            string output = "";

            foreach (var e in emp)
            {
                Console.WriteLine(e.FirstName + " " + e.LastName + " " + e.Manager.FirstName);

                output += $"{e.FirstName} {e.LastName} {e.Manager.FirstName}\r\n";

                foreach (var pr in e.Projects)
                {
                    string endate = (pr.EndDate != null) ? pr.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt") : "";
                    Console.WriteLine($"--{pr.Name} {pr.StartDate.ToString("M/d/yyyy h:mm:ss tt")} {endate}");

                    output += $"--{pr.Name} {pr.StartDate.ToString("M/d/yyyy h:mm:ss tt")} {endate}\r\n";

                }
            }

            File.WriteAllText("output7.txt", output);
        }

        private static void _6_Adding_a_New_Address_and_Updating_Employee(SoftUniContext context)
        {
            Address adr = new Address()
            {
                AddressText = "Vitoshka 15",
                TownID = 4
            };
            context.Addresses.Add(adr);

            Employee emp = context.Employees.Where(x => x.LastName == "Nakov").FirstOrDefault();

            emp.Address = adr;

            context.SaveChanges();

            var employees = context.Employees.OrderByDescending(x => x.AddressID).Select(x => x.Address.AddressText).ToList().Take(10);

            string output = "";
            foreach (var e in employees)
            {
                output += $"{e}\r\n";
            }
            File.WriteAllText("output6.txt", output);
        }

        private static void _5_Employees_from_Research_and_Development(SoftUniContext context)
        {
            var empl = context
                                  .Employees
                                  .Where(x => x.Department.Name == "Research and Development")
                                  .OrderBy(x => x.Salary)
                                  .ThenByDescending(x => x.FirstName);

            string output = "";
            foreach (var e in empl)
            {
                output += $"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:F2}\r\n";
            }
            File.WriteAllText("output5.txt", output);
        }

        private static void _4_Employees_with_Salary_Over_50000(SoftUniContext context)
        {
            var empl = context.Employees.Where(x => x.Salary > 50000).Select(x => x.FirstName).ToList();

            string output = "";

            foreach (var e in empl)
            {
                output += $"{e}\r\n";
            }

            File.WriteAllText("output4.txt", output);
        }

        private static void _3_EmployeesFullInformation(SoftUniContext context)
        {
            var empl = context.Employees.OrderBy(x => x.EmployeeID).ToList();

            string output = "";

            foreach (var e in empl)
            {
                output += $"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:F4}\r\n";
            }

            File.WriteAllText("output3.txt", output);
        }
    }
}
