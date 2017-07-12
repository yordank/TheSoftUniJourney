using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bus : Vehicle
{
    public Bus(double fuelQ, double fuelC, double tankC) : base(fuelQ, fuelC, tankC)
    {

    }
    public override string DriveVehincle(double km)
    {
        double needFuel = km * this.FuelConsumption;

        if (needFuel > this.FuelQuatity)
            return "Bus needs refueling";
        else
            this.FuelQuatity -= needFuel;

        return $"Bus travelled {km} km";

    }

    public  string DriveFullBus(double km)
    {
        
        double needFuel = km * (this.FuelConsumption+1.4);

        if (needFuel > this.FuelQuatity)
            return "Bus needs refueling";
        else
            this.FuelQuatity -= needFuel;

        return $"Bus travelled {km} km";

    }

    public override void Refueled(double litters)
    {
        if (litters <= 0)
            throw new ArgumentException("Fuel must be a positive number");

        this.FuelQuatity += litters;

    }

    public override string ToString()
    {
        return $"Bus: {this.FuelQuatity:f2}";
    }


}


