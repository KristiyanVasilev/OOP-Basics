using System;

public class Dought
{
    private string flour;
    private string technique;
    private double weight;

    public Dought(string flour, string technique, double weight)
    {
        this.Flour = flour;
        this.Technique = technique;
        this.Weight = weight;
    }

    public double GetCalories()
    {
        var calories = 2 * this.Weight;
        switch (this.Flour.ToLower())
        {
            case "white":
                calories *= 1.5;
                break;
            case "wholegrain":
                calories *= 1.0;
                break;
        }
        switch (this.technique.ToLower())
        {
            case "crispy":
                calories *= 0.9;
                break;
            case "chewy":
                calories *= 1.1;
                break;
            case "homemade":
                calories *= 1.0;
                break;
        }
        return calories;
    }

    public string Flour
    {
        get { return this.flour; }
        set
        {
            if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.flour = value;
        }
    }
    public string Technique
    {
        get { return this.technique; }
        set
        {
            if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            this.technique = value;
        }

    }
    public double Weight
    {
        get { return this.weight; }
        set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            this.weight = value;
        }
    }
}

