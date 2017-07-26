using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Turple<K,V>
{
    public Turple(K item1,V item2)
    {
        this.Item1 = item1;

        this.Item2 = item2;
    }

    K item1;
    V item2;

    public K Item1
    {
        get
        {
            return item1;
        }

        set
        {
            item1 = value;
        }
    }

    public V Item2
    {
        get
        {
            return item2;
        }

        set
        {
            item2 = value;
        }
    }

    public override string ToString()
    {
        return $"{Item1.ToString()} -> {Item2.ToString()}";

    }
}

