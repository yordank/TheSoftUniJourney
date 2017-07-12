


public class Rectangle:Shape
    {

    public Rectangle(double h,double w)
    {
        this.Height = h;

        this.Width = w;

    }

    private double height;

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    private double width;

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public override string Draw()
    {
        return base.Draw()+"Rectangle";
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }

    public override double CalculatePerimeter()
    {
        return 2 * this.Height + 2 * this.Width;

    }

}
 
