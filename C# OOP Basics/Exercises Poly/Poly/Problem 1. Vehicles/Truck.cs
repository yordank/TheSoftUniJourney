using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Truck : Vehicle
{
    public Truck(double fuelQ, double fuelC) : base(fuelQ, fuelC + 1.6)
    {

    }
    public override string DriveVehincle(double km)
    {
        double needFuel = km * this.FuelConsumption;
        if (needFuel > this.FuelQuatity)
            return "Truck needs refueling";
        else
            this.FuelQuatity -= needFuel;

        return $"Truck travelled {km} km";

    }
    public override void Refueled(double litters)
    {
        this.FuelQuatity += litters*0.95;

    }

    public override string ToString()
    {
        return $"Truck: {this.FuelQuatity:f2}";
    }


}


