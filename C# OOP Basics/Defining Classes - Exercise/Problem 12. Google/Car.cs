using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_12.Google
{
    public class Car
    {
        public Car(string model,int speed)
        {
            this.Model = model;

            this.carSpeed = speed;

        }
        public string  Model { get; set; }
        public int carSpeed { get; set; }

        public override string ToString()
        {
            return $"{this.Model} {this.carSpeed}";
        }
    }
}
