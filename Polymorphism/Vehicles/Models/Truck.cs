using System;

public class Truck : Vehicle
{
    private const double Modifier = 1.6;
    private const double FuelLoss = 0.95;
    public Truck(double fuel, double consumption, double tankCapacity) : base(fuel, consumption + Modifier, tankCapacity)
    {
    }

    public override void Refuel(double gasolina)
    {
        base.Refuel(gasolina * FuelLoss);
    }
}