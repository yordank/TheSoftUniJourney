using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MyList : Collection, IMyList
{
    public int Add(string element)
    {
        this.List.Insert(0, element);
        return 0;
    }

    public string Remove()
    {
        string temp = this.List[0];
        this.List.RemoveAt(0);
        return temp;
    }

    public int Used
    {
        get
        {
            return this.List.Count;
        }
    }
}
