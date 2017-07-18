using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class CourseNotFoundException : Exception
    {
        public const string NotEnrolledInCourse = "Course Not Found!";

        public CourseNotFoundException() : base(NotEnrolledInCourse)
        {
        }

        public CourseNotFoundException(string message) : base(message)
        {
        }
    }
}
