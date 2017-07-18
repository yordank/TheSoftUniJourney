﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{

    public class InvalidPathException : Exception
    {
        public const string InvalidPath = "Invalid path!The source does not exist.";

        public InvalidPathException() : base(InvalidPath)
        {
        }

        public InvalidPathException(string message) : base(message)
        {
        }
    }
}
