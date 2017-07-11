using System;
using System.Collections.Generic;
using System.Linq;

public class Gandalf
{
    private List<Food> foodEaten;
    public Gandalf()
    {
        foodEaten = new List<Food>();
    }
    public void Eat(Food food)
    {
        this.foodEaten.Add(food);
    }

    public int GetHappinessPoints()
    {
        return foodEaten.Sum(f => f.GetHapinessPoints());
    }
}

