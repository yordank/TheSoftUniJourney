using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Name
{
    public Name(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }

    private string firstName;

    private string lastName;

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public override string ToString()
    {
        return this.firstName+" "+this.lastName;
    }
}

