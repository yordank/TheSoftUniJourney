using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rebel : IBuyer
{
    public Rebel(string name, int age, string group)
    {
        this.Name = name;

        this.Age = age;

        this.Group = group;

    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    private string group;

    public string Group
    {
        get { return group; }
        set { group = value; }
    }

    private int food;

    public int Food
    {
        get { return food; }
        set { food = value; }
    }

    public void BuyFood()
    {
        this.Food += 5;
    }
}

