using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class AddCollection : Collection, IAddCollection
{
    public int Add(string element)
    {
        this.List.Add(element);
        return this.List.Count - 1;
    }
}

