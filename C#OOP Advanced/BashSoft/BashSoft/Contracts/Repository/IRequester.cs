using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts.Repository
{
    public interface IRequester
    {
        void GetStudentScoresFromCourse(string courseName, string username);

        void GetAllStudentsFromCourse(string courseName);

       
    }
}
