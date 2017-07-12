using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Animal
{
    public Animal(string animalName, double weight)
    {
        this.AnimalName = animalName;
        this.AnimalType = this.GetType().Name;
        this.AnimalWeight = weight;
        this.FoodEaten = 0;
    }
    private string animalName;

    public string AnimalName
    {
        get { return animalName; }
        set { animalName = value; }
    }

    private string animalType;

    public string AnimalType
    {
        get { return animalType; }
        set { animalType = value; }
    }

    private double animalWeight;

    public double AnimalWeight
    {
        get { return animalWeight; }
        set { animalWeight = value; }
    }

    private int foodEaten;

    public int FoodEaten
    {
        get { return foodEaten; }
        set { foodEaten = value; }
    }

    public abstract void makeSound();

    public abstract void eat(Food food);


}

