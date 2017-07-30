using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person:IComparable<Person>
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
      
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public override bool Equals(object obj)
    {
        var element = (Person)obj;
        var equals = Object.Equals(this.Name, element.Name) && Object.Equals(this.Age, element.Age);
        return equals;
    }

    public override int GetHashCode()
    {
        return this.CombineHashCodes(this.Name.GetHashCode(), this.Age.GetHashCode());

    }

    private int CombineHashCodes(int h1, int h2)
    {
        return ((h1 << 5) + h1) ^ h2;
    }
    public int CompareTo(Person other)
    {
        return this.GetHashCode().CompareTo(other.GetHashCode());
    }
}

