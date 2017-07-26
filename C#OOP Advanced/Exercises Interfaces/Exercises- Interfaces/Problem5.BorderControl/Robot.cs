using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Robot : ICitizen
{
    public Robot(string model, string id)
    {
        this.id = id;
        this.model = model;
    }

    public string Model
    {
        get { return model; }
        set { model = value; }
    }

    private string id;

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

