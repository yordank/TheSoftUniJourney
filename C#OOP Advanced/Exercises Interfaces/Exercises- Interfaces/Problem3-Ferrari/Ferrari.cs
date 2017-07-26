using System;

public class Ferrari : ICar
{


    private string driver;
    private string model;

    public Ferrari(string driver, string model="488-Spider")
    {
        this.driver = driver;
        this.model = model;
    }

    public string Driver
    {
        get { return driver; }
        set { driver = value; }
    }


    

    public string Model
    {
        get { return model; }
        set { model = value; }
    }


    public string pushTheGas()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.UseBrakes()}/{this.pushTheGas()}/{this.Driver}";
    }
}