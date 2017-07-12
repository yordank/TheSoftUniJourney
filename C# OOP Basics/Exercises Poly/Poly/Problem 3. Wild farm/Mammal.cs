using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Mammal : Animal
{
    public Mammal(string animalName, double weight, string livingRegion)
        : base(animalName, weight)
    {
        this.LivingRegion = livingRegion;
    }

    private string livingRegion;

    public string LivingRegion
    {
        get { return livingRegion; }
        set { livingRegion = value; }
    }

}

