using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Collection
{
    private readonly IList<string> list;

    public Collection()
    {
        this.list = new List<string>();
    }

    public IList<string> List
    {
        get
        {
            return this.list;
        }

    }
}
