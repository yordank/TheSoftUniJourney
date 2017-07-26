using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Drunk
{
    public Drunk(string drunk)
    {
        if (drunk == "drunk")
            this.DrunkOrNot = true;
        else
            this.DrunkOrNot = false;

    }

    private bool drunk;
    public bool DrunkOrNot
    {
        get { return drunk; }
        set { drunk = value; }
    }

    public override string ToString()
    {
        return DrunkOrNot.ToString();
    }

}

