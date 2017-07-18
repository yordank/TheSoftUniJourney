using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidStringException : Exception
    {
        public InvalidStringException() : base(ExceptionMessages.NullOrEmptyValue)
        {
        }

        public InvalidStringException(string message) : base($"{message} {ExceptionMessages.NullOrEmptyValue}")
        {
        }
    }


}
