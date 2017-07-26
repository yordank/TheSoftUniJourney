using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Citizen:ICitizen,IBuyer
{
    public Citizen( string name, int age, string id,string date)
    {
        this.Age = age;
        this.Name = name;
        this.Id = id;
        this.BirthDate = date;
        this.Food = 0;
    }

    private string birthdata;

    public string BirthDate
    {
        get { return birthdata; }
        set { birthdata = value; }
    }

    private int age;

    private string name;

    private string id;
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }    

    private string model;

   

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private int food;

    public int Food
    {
        get { return food; }
        set { food = value; }
    }


    public bool CheckIdEnds(string num)
    {
        return id.EndsWith(num);
    }

    public bool CheckYear(string year)
    {
        return this.BirthDate.EndsWith(year);
    }

    public override string ToString()
    {
        return BirthDate;
    }

    public void BuyFood()
    {
        this.Food += 10;
    }
}

