using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            decimal Top = 0;
            decimal Good = 0;
            decimal Average = 0;
            decimal Poor = 0;

            decimal averageGrade = 0;

            for (int i = 0; i < students;i++)
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                if (grade >= 5) Top++;
                if (grade < 5 && grade >= 4) Good++;
                if (grade < 4 && grade >= 3) Average++;
                if (grade < 3) Poor++;

                averageGrade += grade;

            }
            averageGrade /= students;

            Console.WriteLine($"Top students: {100*Top/students:f2}%");
            
            Console.WriteLine($"Between 4.00 and 4.99: {100*Good/students:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {100 * Average / students:f2}%");
            Console.WriteLine($"Fail: {100 * Poor / students:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
