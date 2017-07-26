using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Citizen:ICitizen
{
    public Citizen( string name, int age, string id)
    {
        this.Age = age;
        this.Name = name;
        this.Id = id;
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
    
    public bool CheckIdEnds(string num)
    {
        return id.EndsWith(num);
    }
}

