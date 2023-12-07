using System;
using System.Text;

namespace BoxData;

public class Box
{
    private double length;
    private double width;
    private double height;

    public double Length
    {
        get
        {
            if (length <= 0)
            {
                throw new ArgumentException("Length cannot be zero or negative.");
            }
            else
            {
                return length;
            }
        }
        set
        {
            length = value;
        }
    }

    public double Width
    {
        get
        {
            if (width <= 0)
            {
                throw new ArgumentException("Width cannot be zero or negative.");
            }
            else
            {
                return width;
            }
        }
        set
        {
            width = value;
        }


    }
    public double Height
    {
        get 
        {
            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be zero or negative.");
            }
            else
            { 
            return height;
            }
        }
        set 
        { 
            height = value;
        }


    }

    public Box(double length, double width, double height) 
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double SurfaceArea()
    {
              return  2*this.length*this.width+2*this.length*this.height + 2*this.width*this.height;
    }

    public double Volume()
    { 
    return this.length*this.width*this.height;
    }

    public override string ToString()
    {
        return $"Surface Area - {this.SurfaceArea():F2}{Environment.NewLine}Volume - {this.Volume():F2}";
    }


}
