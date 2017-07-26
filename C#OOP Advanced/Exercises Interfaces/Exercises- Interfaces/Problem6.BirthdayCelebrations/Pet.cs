using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Pet : ICitizen
{
    public Pet(string name,string date)
    {
        this.Name = name;

        this.BirthDate = date;
    }

    private string birthdate;

    public string BirthDate
    {
        get { return birthdate; }
        set { birthdate = value; }
    }


    private string  name;

    public string  Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Id
    {
        get
        {
            throw new NotImplementedException();
        }

        set
        {
            throw new NotImplementedException();
        }
    }

    public bool CheckIdEnds(string num)
    {
        throw new NotImplementedException();
    }

    public bool CheckYear(string year)
    {
        return BirthDate.EndsWith(year);
    }

    public override string ToString()
    {
        return BirthDate;
    }
}

