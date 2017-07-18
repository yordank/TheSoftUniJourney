using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidStudentFilterException : Exception
    {
        public const string InvalidFilter = "The 'filter' must beone of the following: 'excellent','average' or 'poor'!";

        public InvalidStudentFilterException() : base(InvalidFilter)
        {
        }

        public InvalidStudentFilterException(string message) : base(message)
        {
        }
    }
}
