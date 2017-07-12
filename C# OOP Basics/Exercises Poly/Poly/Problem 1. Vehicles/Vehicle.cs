using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Vehicle
{
    public Vehicle(double fuelQ,double fuelC)
    {
        this.FuelQuatity = fuelQ;

        this.FuelConsumption = fuelC;

    }

    private double fuelQuatity;

    public double FuelQuatity
    {
        get { return fuelQuatity; }
        set { fuelQuatity = value; }
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

