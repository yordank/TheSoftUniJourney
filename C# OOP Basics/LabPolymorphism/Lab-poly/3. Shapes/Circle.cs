
using System;

public class Circle:Shape
{
    public Circle(double r)
    {
        this.Radius = r;
    }
    private double radius;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }
    public override string Draw()
    {
        return base.Draw()+"Circle";
    }

    public override double CalculateArea()
    {
        return this.Radius*this.Radius* Math.PI;
    }

    public override double CalculatePerimeter()
    {
        return 2 *Math.PI*this.Radius;

    }
}

