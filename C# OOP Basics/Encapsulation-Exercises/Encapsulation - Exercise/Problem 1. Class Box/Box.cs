using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box
{

    public Box(decimal l, decimal w, decimal h)
    {
        this.length = l;

        this.width = w;

        this.height = h;

    }

    private decimal length;
    private decimal width;
    private decimal height;

    public decimal surfaceArea()
    {
        return 2 * length * height + 2 * length * width + 2 * width * height;
    }

    public decimal lateralSurfaceArea()
    {
        return 2 * length * height + 2 * width * height;
    }

    public decimal volume()
    {
        return length * width * height;
    }

}

