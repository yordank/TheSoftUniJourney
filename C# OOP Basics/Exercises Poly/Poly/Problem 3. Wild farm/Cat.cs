using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Wild_farm
{
    public class Cat : Felime
    {
        public Cat(string animalName,double weight,string breed,string livingRegion)
            :base(animalName,weight,livingRegion)
        {
            this.Breed = breed;
        }
        private string breed;

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public override void makeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override void eat(Food food)
        {
            this.FoodEaten += food.Quatity;
        }

        public override string ToString()
        {
            return $"{AnimalType}[{AnimalName}, {this.Breed}, {this.AnimalWeight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
