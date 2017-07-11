using System;

public class Car : Vehicle
{
    private const double Modifier = 0.9;
    public Car(double fuel, double consumption, double tankCapacity) : base(fuel, consumption + Modifier, tankCapacity)
    {
    }
    protected override double Fuel
    {
        set
        {
            if (value > this.TankCapacity)
            {
                throw new ArgumentException("Cannot fit fuel in tank");
            }
            base.Fuel = value;
        }
    }
}

