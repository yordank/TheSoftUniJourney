using System;

public class Citizen : IPerson, IBirthable, IIdentifiable
{
    public Citizen(string name, int age, string id, string birthdate)
    {
        Age = age;

        Name = name;

        Id = id;

        Birthdate = birthdate;

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


    private string birthdate;

    public string Birthdate
    {
        get { return birthdate; }
        private set { birthdate = value; }
    }


    private string id;

    public string Id
    {
        get { return id; }
        private set { id = value; }
    }

}