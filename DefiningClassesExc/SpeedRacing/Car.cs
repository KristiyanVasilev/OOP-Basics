using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private double distanceTraveled;

    public Car(string model, int fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
    }
    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }
    public double DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }
    public void CalculateDistance(double kilometers)
    {
        var neededFuel = kilometers * this.fuelConsumption;
        if (neededFuel > this.fuelAmount)
        {
           Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.fuelAmount -= neededFuel;
            this.DistanceTraveled += kilometers;
        }
    }
}

