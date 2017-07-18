using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidComparisonQueryException : Exception
    {
        public const string InvalidComparisonQuery = "Invalid Comparison Query!";

        public InvalidComparisonQueryException() : base(InvalidComparisonQuery)
        {
        }

        public InvalidComparisonQueryException(string message) : base(message)
        {
        }
    }
}
