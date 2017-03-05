using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var listStudents = new List<Student>();

            while(input!="End")
            {
                Student student = new Student(input);
                listStudents.Add(student);

                input = Console.ReadLine();
            }
            Console.WriteLine(Student.count);


        }
    }
}
