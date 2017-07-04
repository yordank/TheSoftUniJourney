using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Raw_Data
{
    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, decimal tirePresure1, int tireAge1, decimal tirePresure2, int tireAge2, decimal tirePresure3, int tireAge3, decimal tirePresure4, int tireAge4)
        {
            this.model = model;
            eng = new Engine(engineSpeed, enginePower);
            cargo = new Cargo(cargoWeight, cargoType);
            tires = new List<Tire>();
            Tire newTire1 = new Tire(tirePresure1, tireAge1);
            tires.Add(newTire1);
            Tire newTire2 = new Tire(tirePresure2, tireAge2);
            tires.Add(newTire2);
            Tire newTire3 = new Tire(tirePresure3, tireAge3);
            tires.Add(newTire3);
            Tire newTire4 = new Tire(tirePresure4, tireAge4);
            tires.Add(newTire4);
        }
        public string model;
        public Engine eng;
        public Cargo cargo;
        public List<Tire> tires;
    }
    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            this.engineSpeed = engineSpeed;
            this.enginePower = enginePower;
        }
        public int engineSpeed;
        public int enginePower;

    }
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            this.cargoWeight = cargoWeight;
            this.cargoType = cargoType;
        }
        public int cargoWeight;
        public string cargoType;
    }
    class Tire
    {
        public Tire(decimal tirePresure, int tireAge)
        {
            this.tirePresure = tirePresure;
            this.tireAge = tireAge;
        }

        public decimal tirePresure;
        public int tireAge;

    }
    class Program
    {
        static void Main(string[] args)
        {
            //“<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>
            int count = int.Parse(Console.ReadLine());

            var CarList = new List<Car>();

            for (int i = 0; i < count; i++)
            {
                var items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var newCar = new Car(items[0], int.Parse(items[1]), int.Parse(items[2]), int.Parse(items[3]), items[4], decimal.Parse(items[5]), int.Parse(items[6]), decimal.Parse(items[7]), int.Parse(items[8]), decimal.Parse(items[9]), int.Parse(items[10]), decimal.Parse(items[9]), int.Parse(items[10]));
                CarList.Add(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                CarList.Where(x => x.cargo.cargoType == "fragile" && x.tires.Where(y => y.tirePresure < 1).Count() > 0).ToList().ForEach(x => Console.WriteLine(x.model));
            }
            if (command == "flamable")
            {
                CarList.Where(x => x.cargo.cargoType == "flamable" && x.eng.enginePower > 250).ToList().ForEach(x => Console.WriteLine(x.model));
            }

        }
    }
}
