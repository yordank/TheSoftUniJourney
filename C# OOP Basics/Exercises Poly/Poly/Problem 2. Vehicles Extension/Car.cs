using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle
{
    public Car(double fuelQ, double fuelC, double tankC) : base(fuelQ, fuelC + 0.9, tankC)
    {

    }
    public override string DriveVehincle(double km)
    {
        double needFuel = km * this.FuelConsumption;
        if (needFuel > this.FuelQuatity)
            return "Car needs refueling";
        else
            this.FuelQuatity -= needFuel;

        return $"Car travelled {km} km";

    }
    public override void Refueled(double litters)
    {
        if (litters <= 0)
            throw new ArgumentException("Fuel must be a positive number");

        this.FuelQuatity += litters;

    }

    public override string ToString()
    {
        return $"Car: {this.FuelQuatity:f2}";
    }


}


