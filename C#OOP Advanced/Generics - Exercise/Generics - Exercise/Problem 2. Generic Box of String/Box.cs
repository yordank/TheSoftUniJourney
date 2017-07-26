using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box<T>
{
    public Box(T elem)
    {
        this.Value = elem;
    }
    private T value;

    public T Value
    {
        get { return value; }
        set { this.value = value; }
    }

    public override string ToString()
    {
        return $"{Value.GetType().FullName}: {this.Value}";
    }
}

