﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Zebra : Mammal
{
    public Zebra(string animalName, double weight, string livingRegion)
        : base(animalName, weight, livingRegion)
    {

    }
    public override void makeSound()
    {
        Console.WriteLine("Zs");
    }

    public override void eat(Food food)
    {
        if (!food.GetType().Name.Equals("Vegetable"))
            Console.WriteLine("Zebras are not eating that type of food!");
        else
            this.FoodEaten += food.Quatity;
    }
    public override string ToString()
    {
        return $"{AnimalType}[{AnimalName}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}

