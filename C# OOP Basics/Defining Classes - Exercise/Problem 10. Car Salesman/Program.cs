using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    class Car
    {
        public Car(string model, Engine eng, int? weight, string color)
        {
            this.model = model;
            this.engine = eng;

            if (weight != null)
                this.weight = weight;
            else
                this.weight = -1;

            if (color != null)
                this.color = color;
            else
                this.color = "n/a";


        }

        public string model;
        public Engine engine;
        public int? weight;
        public string color;

        public override string ToString()
        {
            var weightOutput = (this.weight == -1) ? "n/a" : this.weight.ToString();

            var output = $"{this.model}:\n  {this.engine.ToString()}\n  Weight: {weightOutput}\n  Color: {this.color}";
            return output;
        }

    }
    class Engine
    {
        public Engine(string model, int power, int? displacement, string efficiency)
        {
            this.model = model;
            this.power = power;

            if (displacement != null)
                this.displacement = displacement;
            else
                this.displacement = -1;

            if (efficiency != null)
                this.efficiency = efficiency;
            else
                this.efficiency = "n/a";

        }
        public override string ToString()
        {
            var displacementOutput = (this.displacement == -1) ? "n/a" : this.displacement.ToString();



            var output = $"{this.model}:\n    Power: {this.power}\n    Displacement: {displacementOutput}\n    Efficiency: {this.efficiency}";

            return output;
        }
        public string model;
        public int power;
        public int? displacement;
        public string efficiency;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var EngineList = new List<Engine>();
            int countEngine = int.Parse(Console.ReadLine());

            for (int i = 0; i < countEngine; i++)
            {

                var items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (items.Count() == 2)
                {
                    var newEngine = new Engine(items[0], int.Parse(items[1]), null, null);
                    EngineList.Add(newEngine);

                }
                else if (items.Count() == 3)
                {
                    int num1;
                    bool res = int.TryParse(items[2], out num1);

                    if (res == false)
                    {
                        var newEngine = new Engine(items[0], int.Parse(items[1]), null, items[2]);
                        EngineList.Add(newEngine);
                    }

                    else
                    {
                        var newEngine = new Engine(items[0], int.Parse(items[1]), int.Parse(items[2]), null);
                        EngineList.Add(newEngine);
                    }


                }
                else
                {
                    var newEngine = new Engine(items[0], int.Parse(items[1]), int.Parse(items[2]), items[3]);
                    EngineList.Add(newEngine);

                }
            }

            int countCars = int.Parse(Console.ReadLine());

            var CarList = new List<Car>();

            for (int i = 0; i < countCars; i++)
            {
                var items = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var curEngine = EngineList.Where(x => x.model == items[1]).First();

                if (items.Count() == 2)
                {
                    var newCar = new Car(items[0], curEngine, null, null);

                    CarList.Add(newCar);
                }

                if (items.Count() == 3)
                {

                    int num1;
                    bool res = int.TryParse(items[2], out num1);

                    if (res == false)
                    {
                        var newCar = new Car(items[0], curEngine, null, items[2]);

                        CarList.Add(newCar);
                    }

                    else
                    {
                        var newCar = new Car(items[0], curEngine, int.Parse(items[2]), null);

                        CarList.Add(newCar);
                    }

                }

                if (items.Count() == 4)
                {
                    var newCar = new Car(items[0], curEngine, int.Parse(items[2]), items[3]);

                    CarList.Add(newCar);
                }


            }

            CarList.ForEach(x => Console.WriteLine(x.ToString()));




        }
    }
 
