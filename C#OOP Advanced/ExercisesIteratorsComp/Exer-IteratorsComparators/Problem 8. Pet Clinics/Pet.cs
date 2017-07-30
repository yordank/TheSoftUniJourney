using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pet
{
    public Pet(string name="TEST", int age=1912, string kind="TEST")
    {
        Name = name;
        Age = age;
        Kind = kind;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Kind { get; set; }

    public override string ToString()
    {
        return $"{this.Name} {this.Age} {this.Kind}";
    }
}

