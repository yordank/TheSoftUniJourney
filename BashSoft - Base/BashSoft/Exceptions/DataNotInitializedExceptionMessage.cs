using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{

    public class DataNotInitializedExceptionMessage : Exception
    {
        public const string DataNotInitializedMessage = "The Data Not Initialized!";

        public DataNotInitializedExceptionMessage() : base(DataNotInitializedMessage)
        {
        }

        public DataNotInitializedExceptionMessage(string message) : base(message)
        {
        }
    }
}
