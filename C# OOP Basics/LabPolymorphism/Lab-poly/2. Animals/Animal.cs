using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Animal
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private string favouriteFood;

    public string FavouriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }

    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
    }

}

