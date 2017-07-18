﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class ExceptionMessages
    {
        public const string DataAlreadyInitialisedException = "Data is already initialized!";

        public const string DataNotInitializedExceptionMessage = "The data structure must be initialised first in order to make any operations with it.";

        public const string InexistingCourseInDataBase = "The course you are trying to get does not exist in the data base!";

        public static string InexistingStudentInDataBase = "The user name for the student you are trying to get does not exist!";

        public static string InvalidPath = "The folder/file you are trying to access at the current address, does not exist.";

        public static string UnauthorizedExceptionMessage =
            "The folder/file you are trying to get access needs a higher level of rights than you currently have.";

        public static string ComparisonOfFilesWithDifferentSizes = "Files not of equal size, certain mismatch.";

        public static string ForbiddenSymbolsContainedInName =
            "The given name contains symbols that are not allowed to be used in names of files and folders.";

        public static string UnableToGoHigherInParitionHierarchy = "Unable to go higher in partition hierarchy.";

        public static string UnableToParseNumber = "The sequence you've written is not a valid number.";

        public static string InvalidStudentFilter =
            "The given filter is not one of the following: excellent/average/poor";

        public static string InvalidQueryComparison =
            "The comparison query you want, does not exist in the context of the current program!";

        public static string InvalidTakeQueryParamter = "The take command expected does not match the format wanted!";

        public static string UnableToGoHigherInPartitionHierarchy = "Impossible operation. There is no higher folder than current one.";
        public static string NullOrEmptyValue = "The value of the variable CANNOT be null or empty!";
        public static string InvalidScores = "The number for the score you've entered is not in the range of 0 - 100";
        public static string InvalidNumberOfScores = "The number of scores for the given course is greater than the possible.";
    }
}
