using System;

public class Vehicle
{
    //private double fuel;
    //private double consumption;
    //private double tankCapacity;

    public Vehicle(double fuel, double consumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.Fuel = fuel;
        this.Consumption = consumption;
    }

    protected virtual double Fuel { get; set; }

    protected double Consumption { get; set; }

    protected virtual double TankCapacity { get; set; }

    protected virtual bool Drive(double kilometers, bool IsAcOn)
    {
        var neededFuel = this.Consumption * kilometers;
        if (neededFuel <= this.Fuel)
        {
            this.Fuel -= neededFuel;
            return true;
        }
        return false;
    }
    public string TryTravelDistance(double distance, bool IsAcOn)
    {
        if (Drive(distance, IsAcOn))
        {
            return $"{this.GetType().Name} travelled {distance} km";
        }
        else
        {
            return $"{this.GetType().Name} needs refueling";
        }
    }
    public string TryTravelDistance(double distance)
    {
        return this.TryTravelDistance(distance, true);
    }

    public virtual void Refuel(double gasolina)
    {
        if (gasolina <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        this.Fuel += gasolina;
    }
    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.Fuel:f2}";
    }
}

