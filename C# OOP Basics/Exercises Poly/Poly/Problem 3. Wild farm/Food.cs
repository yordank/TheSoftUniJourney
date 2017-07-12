using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Food
{
    public Food(int quatity)
    {
        this.Quatity = quatity;
    }
    private int quatity;

    public int Quatity
    {
        get { return quatity; }
        set { quatity = value; }
    }

}

