using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Box
{

    public Box(decimal l, decimal w, decimal h)
    {
        this.Length = l;

        this.Width = w;

        this.Height = h;

    }

    private decimal length;

    private decimal width;

    private decimal height;

    public decimal Length
    {
        get
        {
            return this.length;
        }
        private set
        {
            if (value > 0)
            {
                this.length = value;
            }
            else
            {
                throw new ArgumentException("Length cannot be zero or negative. ");
            }
        }
    }

    public decimal Width
    {
        get
        {
            return this.width;
        }
        private set
        {
            if (value > 0)
                this.width = value;

            else
            {
                throw new ArgumentException("Width cannot be zero or negative. ");
            }
        }
    }

    public decimal Height
    {
        get
        {
            return this.height;
        }
        private set
        {
            if (value > 0)
                this.height = value;
            else

            {
                throw new ArgumentException("Height cannot be zero or negative. ");
            }
        }
    }
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

