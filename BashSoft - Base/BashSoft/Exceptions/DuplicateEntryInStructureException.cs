﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Exceptions
{
    public class DuplicateEntryInStructureException : Exception
    {
        public const string DuplicateEntry = "This {0} is already enrolled in {1}!";

        public DuplicateEntryInStructureException(string message) : base(message)
        {
        }

        public DuplicateEntryInStructureException(string entry, string structure)
            : base(string.Format(DuplicateEntry, entry, structure))
        {
        }
    }
}
