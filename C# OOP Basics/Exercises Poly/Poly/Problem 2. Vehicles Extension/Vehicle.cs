using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Vehicle
{
    public Vehicle(double fuelQ, double fuelC, double tankC)
    {
        this.TankCapacity = tankC;

        this.FuelQuatity = fuelQ;

        this.FuelConsumption = fuelC;

       

    }

    private double fuelQuatity;

    public double FuelQuatity
    {
        get { return fuelQuatity; }
        set
        {
            
            
            if (value <= 0)
                throw new ArgumentException("Fuel must be a positive number");
            if (!this.GetType().Name.Equals("Truck") && value > this.tankCapacity  )
                throw new ArgumentException("Cannot fit fuel in tank");
            fuelQuatity = value;
        }
    }

    private double fuelConsumption;

    public double FuelConsumption
    {
        get { return fuelConsumption; }
        set { fuelConsumption = value; }
    }

    private double tankCapacity;

    public double TankCapacity
    {
        get { return tankCapacity; }
        set { tankCapacity = value; }
    }


    public abstract void Refueled(double litters);
    public abstract string DriveVehincle(double km);



}

