using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _8.Mentor_group
{
    class Student
    {

        public List<DateTime> dates { get; set; }
        public List<string> comments { get; set; }
        public string name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end of dates")
            {

                Student student = new Student();

                var NameDates = input.Split();
                int a = 5;
                if (NameDates.Count() == 1)
                {


                    if (students.Where(x => x.name == NameDates[0]).Count() == 0)
                    {
                        student.dates = new List<DateTime>();
                        student.name = NameDates[0];
                        student.comments = new List<string>();

                        students.Add(student);
                        
                    }
                    input = Console.ReadLine();

                     


                }
                else
                {
                    string Name = NameDates[0];
                    List<DateTime> dates = new List<DateTime>();

                    var d = NameDates[1].Split(',');

                    foreach (var item in d)
                    {
                        var DayMonthYear = item.Split('/');
                        int day = int.Parse(DayMonthYear[0]);
                        int month = int.Parse(DayMonthYear[1]);
                        int year = int.Parse(DayMonthYear[2]);

                        DateTime datetime = new DateTime(year, month, day);
                        dates.Add(datetime);
                    }

                    //if(students.Where(x=>x.name==Name).Count()>0)


                    student.dates = dates;
                    student.name = Name;

                    List<string> comments = new List<string>();
                    //comments.Add("");
                    student.comments = comments;

                    if (students.Where(x => x.name == Name).Count() > 0)
                    {
                        foreach (var item in dates)
                        {
                            students.Where(x => x.name == Name).Single().dates.Add(item);
                        }

                    }
                    else
                        students.Add(student);

                    input = Console.ReadLine();
                }

            }

            input = Console.ReadLine();

            while (input != "end of comments")
            {

                var NameComment = input.Split('-');

                string Name = NameComment[0];
                string Comment = NameComment[1];

                var student = students.Where(x => x.name == Name);
                if (student.Count() > 0)
                {
                    // if (student.Single().comments.Count() == 0)
                    {
                        Student stud = new Student();
                        stud = student.Single();
                        List<string> StudentComments = new List<string>();


                        StudentComments.Add(Comment);
                        stud.comments.Add(Comment);

                        students.Where(x => x.name == Name).Single().comments = stud.comments;
                    }

                }

                input = Console.ReadLine();
            }




            foreach (var item in students.OrderBy(x => x.name))
            {

                Console.WriteLine(item.name);
                Console.WriteLine("Comments:");
                
                if (item.comments.Count() > 0)
                    Console.WriteLine($"- {string.Join("\n- ",item.comments)}");


                Console.WriteLine("Dates attended:");

                foreach (var item2 in item.dates.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item2.ToString("dd/MM/yyyy")}");
                }


            }

        }
    }
}