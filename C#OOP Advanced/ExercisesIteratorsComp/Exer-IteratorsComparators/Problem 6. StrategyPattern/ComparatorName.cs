using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ComparatorName : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            result = Char.ToUpper(x.Name[0]).CompareTo(Char.ToUpper(y.Name[0]));
        }

        return result;
    }
}
