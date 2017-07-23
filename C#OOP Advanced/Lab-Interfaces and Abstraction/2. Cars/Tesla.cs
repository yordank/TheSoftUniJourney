using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tesla : ICar, IElectricCar
{
    public string Model { get; private set; }
    public string Color { get; private set; }
    public int Batteries { get; private set; }
    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;

    }
    public string Start()
    {
        return "Car started!";
    }
    public string Stop()
    {
        return "Car stopped!";
    }
}


