using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mission : IMission
{
    public Mission(string name, string state)
    {
        this.Name = name;
        this.State = state;
    }

    public string Name { get; private set; }

    public string State { get; private set; }

    public override string ToString()
    {
        return $"Code Name: {this.Name} State: {this.State}";
    }
}
