using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class InvalidFileNameException : Exception
    {
        
        public InvalidFileNameException() 
        {
        }

        public InvalidFileNameException(string message) : base(message)
        {
        }
    }
}
