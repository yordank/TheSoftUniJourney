using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SimpleJudge;

namespace BashSoft
{
    public static class StudentsRepository
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;


        public static void InitializedData(string fileName)
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");

                studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadData(fileName);
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitialisedException);

            }

        }

        private static void ReadData(string fileName)
        {
            //string input = Console.ReadLine();

           // while (!string.IsNullOrEmpty(input))
           

            string path = SessionData.currentPath + "\\" + fileName;

            string pattern = @"([A-Z][a-zA-Z#+]*_[A-Z][a-z]{2}_\d{4})\s+([A-Z][a-z]{0,3}\d{2}_\d{2,4})\s+(\d+)";

            Regex rgx = new Regex(pattern);

            //string[] allinputLines = File.ReadAllLines(path);

            if (File.Exists(path))
            {

                string[] allInputLines = File.ReadAllLines(path);


                for (int line = 0; line < allInputLines.Length; line++)
                {
                    if (!string.IsNullOrEmpty(allInputLines[line]) && rgx.IsMatch(allInputLines[line]))
                    {

                        Match currentMatch = rgx.Match(allInputLines[line]);

                        string courseName = currentMatch.Groups[1].Value;

                        string username = currentMatch.Groups[2].Value;

                        int studentScoreOnTask;

                        bool hasParsedScore = int.TryParse(currentMatch.Groups[3].Value, out studentScoreOnTask);



                        if (hasParsedScore && studentScoreOnTask >= 0 && studentScoreOnTask <= 100)
                        {

                            if (!studentsByCourse.ContainsKey(courseName))
                            {
                                studentsByCourse.Add(courseName, new Dictionary<string, List<int>>());
                            }

                            if (!studentsByCourse[courseName].ContainsKey(username))
                            {
                                studentsByCourse[courseName].Add(username, new List<int>());
                            }

                            studentsByCourse[courseName][username].Add(studentScoreOnTask);
                        }


                    }
                }

               

                


            }

            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidPath);
            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");


        }

        private static bool isQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayException(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private static bool isQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (isQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayException(ExceptionMessages.InexistingStudentInDataBase);
            }
            return false;
            
        }

       

        public static void GetStudentScoresFromCource(string courseName, string username)
        {
            if (isQueryForStudentPossible(courseName,username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public static void GetAllStudentsFromCourse(string courseName)
        {
            if (isQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");

                foreach (var studenMarksEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studenMarksEntry);
                }

            }
        }

        public static void FilterAndTake(string courseName, string givenFilter, int? studentsToTake = null)
        {
            if (isQueryForCoursePossible(courseName))
            {
                if (studentsToTake == null)
                {
                    studentsToTake = studentsByCourse[courseName].Count;
                }

                RepositoryFilters.FilterAndTake(studentsByCourse[courseName], givenFilter, studentsToTake.Value);

            }
        }

        public static void OrderAndTake(string courseName, string comparison, int? studensToTake = null)
        {
            if (isQueryForCoursePossible(courseName))
            {
                if (studensToTake == null)
                {
                    studensToTake = studentsByCourse[courseName].Count;
                }

                RepositorySorters.OrderAndTake(studentsByCourse[courseName], comparison, studensToTake.Value);
            }
        }

    }
}
