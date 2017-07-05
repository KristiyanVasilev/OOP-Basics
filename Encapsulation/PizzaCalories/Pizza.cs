using System;
using System.Collections.Generic;
using System.Linq;

public class Pizza
{
    private string name;
    private Dought dought;
    private List<Topping> toppings;
    private int numberOfToppings;

    public Pizza(string name, int numberOfToppings)
    {
        this.Name = name;
        this.toppings = new List<Topping>();
        this.NumberOfToppings = numberOfToppings;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value.Length < 1 || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }
            this.name = value;
        }
    }
    public Dought Dought
    {
        get { return this.dought; }
        set { this.dought = value; }
    }

    public int NumberOfToppings
    {
        get { return this.numberOfToppings; }

        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            numberOfToppings = value;
        }
    }
    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }

    public double GetCalories()
    {
        return this.dought.GetCalories() + this.toppings.Sum(t => t.GetCalories());
    }
}

