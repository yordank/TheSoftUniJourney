using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddRemoveCollection : Collection, IAddRemoveCollection
{
    public int Add(string element)
    {
        this.List.Insert(0, element);
        return 0;
    }

    public string Remove()
    {
        string temp = this.List[this.List.Count - 1];
        this.List.RemoveAt(this.List.Count - 1);
        return temp;
    }
}

