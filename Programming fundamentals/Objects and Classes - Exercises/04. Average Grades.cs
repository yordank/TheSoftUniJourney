using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Average_Grades
{
    class Student
    {
        public string Name { get; set; }

        public List<decimal> Grades
        {
            get;
            set;
        }

        public decimal AverageGrade
        {
            get
            {
                return Grades.Sum()/Grades.Count();
            }
       }


    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var Marks = input.Where((value, index) => index > 0).Select(decimal.Parse).ToList();
            Student Ith_student = new Student { Name = input[0] ,Grades=Marks};
                students.Add(Ith_student);
            }

            var OrderedStudents = students.OrderBy(stud=>-stud.AverageGrade).OrderBy(stud=>stud.Name).Where(stud=>stud.AverageGrade>=5);

            foreach (var item in OrderedStudents)
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade:f2}");
            }                
        }
    }
}
