using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Citizen : IResident, IPerson
{
    public Citizen(string name, string country, int age)
    {
        this.age = age;
        this.country = country;
        this.name = name;
    }

    private int age;

    private string country;

    private string name;



    int IPerson.Age
    {
        get
        {
            return this.age;
        }
    }

    string IResident.Country
    {
        get
        {
            return this.country;
        }


    }

    string IPerson.Name
    {
        get
        {
            return this.name;
        }

    }

    string IResident.Name
    {
        get
        {
            return this.name;
        }
    }

    string IPerson.GetName()
    {
        return $"Mr/Ms/Mrs {this.name}";
    }

    string IResident.GetName()
    {
        return this.name;
    }
}

