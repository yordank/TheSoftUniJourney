using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
     

    public class DataAlreadyInitialisedException : Exception
    {
        public const string NotEnrolledInCourse = "Data Already Initialised!";

        public DataAlreadyInitialisedException() : base(NotEnrolledInCourse)
        {

        }

        public DataAlreadyInitialisedException(string message) : base(message)
        {

        }

    }
}
