using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Threeuple<K, V, T> : Tuple<K, V>
{
    public Threeuple(K item1, V item2,T item3) 
        : base(item1, item2)
    {
        this.Item3 = item3;
    }
    private T item3;

    public T Item3
    {
        get { return item3; }
        set { item3 = value; }
    }

    public override string ToString()
    {
        return $"{Item1.ToString()} -> {Item2.ToString()} -> {Item3.ToString()}";
    }


}

