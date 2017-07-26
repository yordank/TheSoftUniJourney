using System;

public class Citizen : IPerson
{
    public Citizen( string name,int age)
    {
        Age = age;
        Name = name;
    }


    private int age;

    public int Age
    {
        get { return age; }
        private set { age = value; }
    }

    private string name;

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }


}