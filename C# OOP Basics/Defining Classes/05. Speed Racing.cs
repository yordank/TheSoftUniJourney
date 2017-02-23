using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace _05.Speed_Racing
{
    class Car
    {
        public Car(string Model,decimal fuelamount,decimal fuelcostfor1kilometer,decimal distancetraveled)
        {
            this.Model = Model;
            this.fuelamount = fuelamount;
            this.fuelcostfor1kilometer = fuelcostfor1kilometer;
            this.distancetraveled = distancetraveled;
        }

        public bool CanTravell(decimal distance)
        {
         return   distance <= this.fuelamount / this.fuelcostfor1kilometer;
        }
        public void ReduceFuelAmount(decimal distance)
        {
            this.fuelamount-= distance * fuelcostfor1kilometer;
            this.distancetraveled += distance;
        }
        public string Model;
        public decimal fuelamount;
        public decimal fuelcostfor1kilometer;
        public decimal distancetraveled;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var CarList = new List<Car>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var items = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
                Car newCar = new Car(items[0],decimal.Parse(items[1]),decimal.Parse(items[2]),0);
                CarList.Add(newCar);
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
               
                var items = inputLine.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var curCar = CarList.Where(x => x.Model == items[1]).First();

                if (curCar.CanTravell(decimal.Parse(items[2])))
                {
                    curCar.ReduceFuelAmount(decimal.Parse(items[2]));

                }

                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }

    
                inputLine = Console.ReadLine();
            }

            CarList.ForEach(x => Console.WriteLine($"{x.Model} {x.fuelamount:f2} {x.distancetraveled}"));


        }
    }
}
