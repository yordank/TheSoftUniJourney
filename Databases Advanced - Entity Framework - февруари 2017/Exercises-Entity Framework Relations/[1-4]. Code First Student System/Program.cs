using _1.Code_First_Student_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Code_First_Student_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new StudentSystemContext();


            //ListStudentsAndHomeworks(context);



            //AllCoursesAndCorrespondingResources(context);



            //CoursesWithMoreThan5Resorces(context);



            //ListAllCoursesWhichWereActiveOnaGivenDate(context);


            //CoursesPerStudent(context);

             

        }

        private static void CoursesPerStudent(StudentSystemContext context)
        {
            var student = context
                          .Students
                          .OrderByDescending(s => s.Courses.Sum(c => c.Price))
                          .ThenByDescending(s => s.Courses.Count())
                          .ThenBy(s => s.Name);

            foreach (var s in student)
            {
                Console.WriteLine($"studentName:{s.Name} courses:{s.Courses.Count()} Totalprice:{s.Courses.Sum(c => c.Price)} avg:{s.Courses.Average(c => c.Price)}");
            }
        }

        private static void ListAllCoursesWhichWereActiveOnaGivenDate(StudentSystemContext context)
        {
            Console.Write("enterDate:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            
            var courses = context
                          .Courses
                          .Where(x => x.StartDate <= date && x.EndDate >= date)
                          .ToList()
                          .OrderByDescending(x => x.Students.Count())
                          .ThenByDescending(x => (x.EndDate - x.StartDate).Days);

            foreach (var c in courses)
            {
                Console.WriteLine($"course:{c.Name}  start:{c.StartDate} end:{c.EndDate} duration:{c.EndDate - c.StartDate} students:{c.Students.Count()}");
            }
        }

        private static void CoursesWithMoreThan5Resorces(StudentSystemContext context)
        {
            var courses = context.Courses.Where(x => x.Resources.Count() > 5).OrderByDescending(x => x.Resources.Count()).ThenByDescending(x => x.StartDate);

            foreach (var c in courses)
            {
                Console.WriteLine($"{c.Name} {c.Resources.Count()}");
            }
        }

        private static void AllCoursesAndCorrespondingResources(StudentSystemContext context)
        {
            var courses = context.Courses.OrderBy(x => x.StartDate).ThenByDescending(x => x.EndDate).ToList();

            foreach (var c in courses)
            {
                Console.WriteLine($"{c.Name} {c.Description}");
                foreach (var res in c.Resources)
                {
                    Console.WriteLine($"--{res.Name } {res.ResourceType} {res.Url} ");
                }
            }
        }

        private static void ListStudentsAndHomeworks(StudentSystemContext context)
        {
            var students = context.Students.ToList();

            foreach (var stud in students)
            {
                Console.WriteLine(stud.Name);

                foreach (var homework in stud.Homeworks)
                {
                    Console.WriteLine($"--homework:content-{homework.Content},contenttype-{homework.ContentType}");
                }
            }
        }
    }
}
