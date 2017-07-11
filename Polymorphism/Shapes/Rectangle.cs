using System;

public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double widht)
    {
        this.Height = height;
        this.Width = widht;
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public override double CalculatePerimeter()
    {
        return this.height * 2 + this.width * 2;
    }

    public override double CalculateArea()
    {
        return this.Height * this.Width;
    }
    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}

