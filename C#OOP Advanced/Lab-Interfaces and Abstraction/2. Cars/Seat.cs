using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Seat : ICar
{
    public Seat(string model, string color)
    {
        this.Color = color;
        this.Model = model;
    }
    public string Color
    {
        get;
        private set;
    }

    public string Model
    {
        get;
        private set;
    }

    public string Start()
    {
        throw new NotImplementedException();
    }

    public string Stop()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return base.ToString();
    }
}

