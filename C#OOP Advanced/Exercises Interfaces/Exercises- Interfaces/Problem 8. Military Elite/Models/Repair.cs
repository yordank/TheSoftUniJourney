using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Repair : IRepair
{
    public Repair(string name, int hours)
    {
        this.Name = name;
        this.Hours = hours;
    }

    public string Name { get; private set; }

    public int Hours { get; private set; }

    public override string ToString()
    {
        return $"Part Name: {this.Name} Hours Worked: {this.Hours}";
    }
}
