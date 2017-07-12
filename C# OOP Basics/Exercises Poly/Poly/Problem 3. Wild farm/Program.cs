using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Wild_farm
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            var input = Console.ReadLine();

            while(input!="End")
            {
                var animalItems = input.Split();
                Animal animal = null;
                switch(animalItems[0])
                {
                    case "Cat":
                        animal = new Cat(animalItems[1], double.Parse(animalItems[2]), animalItems[4], animalItems[3]);
                        break;
                    case "Zebra":
                        animal = new Zebra(animalItems[1], double.Parse(animalItems[2]), animalItems[3]);
                        break;
                    case "Tiger":
                        animal = new Tiger(animalItems[1], double.Parse(animalItems[2]), animalItems[3]);
                        break;
                    case "Mouse":
                        animal = new Mouse(animalItems[1], double.Parse(animalItems[2]), animalItems[3]);
                        break;



                }

                animal.makeSound();

                var foodItems = Console.ReadLine().Split();

                Food food = null;

                if (foodItems[0] == "Vegetable")
                    food = new Vegetable(int.Parse(foodItems[1]));

                if (foodItems[0] == "Meat")
                    food = new  Meat(int.Parse(foodItems[1]));

                 
                animal.eat(food);

                Console.WriteLine(animal.ToString());

                input = Console.ReadLine();

            }



        }
    }
}
