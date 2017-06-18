using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    class Launcher
    {
        static void Main(string[] args)
        {
            //IOManager.TraverseDirectory(@"C:\");

            //StudentsRepository.InitializedData();
            //StudentsRepository.GetAllStudentsFromCourse("Unity");

            StudentsRepository.InitializedData();
            StudentsRepository.GetStudentScoresFromCource( "Unity","Ivan");
        }
    }
}
