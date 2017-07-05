using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    private double Length
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }
            this.length = value;
        }
    }
    private double Width
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }
            this.width = value;
        }
    }
    private double Height
    {
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }
            this.height = value;
        }
    }

    public Box(double length, double width, double height)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
    public void PrintSurfaceArea()
    {
        var result = (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        System.Console.WriteLine($"Surface Area - {result:f2}");
    }
    public void PritnLaterlSurfaceArea()
    {
        var result = (2 * this.length * this.height) + (2 * this.width * this.height);
        System.Console.WriteLine($"Lateral Surface Area - {result:f2}");
    }
    public void PrintVolume()
    {
        var result = this.length * this.width * this.height;
        System.Console.WriteLine($"Volume - {result:f2}");
    }
}
