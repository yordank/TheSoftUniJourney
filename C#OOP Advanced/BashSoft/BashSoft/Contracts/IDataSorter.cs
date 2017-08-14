using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft.Contracts
{
    public interface IDataSorter
    {
        void OrderAndTake(Dictionary<string, double> studentsWithMark, string comparison, int studentsToTake);
    }
}
