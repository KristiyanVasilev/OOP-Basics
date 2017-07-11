using System;

public class Bus : Vehicle
{
    private const double Modifier = 1.4;
    public Bus(double fuel, double consumption, double tankCapacity) : base(fuel, consumption, tankCapacity)
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
    protected override bool Drive(double kilometers, bool IsAcOn)
    {
        double requredFuel = 0;
        if (IsAcOn)
        {
            requredFuel = kilometers * (this.Consumption + Modifier);
        }
        else
        {
            requredFuel = kilometers * this.Consumption;
        }

        if (requredFuel <= this.Fuel)
        {
            this.Fuel -= requredFuel;
            return true;
        }
        return false;
    }
}

