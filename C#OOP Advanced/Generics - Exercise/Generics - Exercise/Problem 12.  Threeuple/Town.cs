using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Town
{
    public Town(string townName)
    {
        this.TownName = townName;
    }

    private string townName;

    public string TownName
    {
        get { return townName; }
        set { townName = value; }
    }

    public override string ToString()
    {
        return this.TownName;
    }

}

