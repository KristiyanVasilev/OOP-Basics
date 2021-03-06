﻿using System;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    public int Shooting
    {
        get { return shooting; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            shooting = value;
        }
    }


    public int Passing
    {
        get { return passing; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            passing = value;
        }
    }

    public int Dribble
    {
        get { return dribble; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Dribble should be between 0 and 100.");
            }
            dribble = value;
        }
    }
    public int Sprint
    {
        get { return sprint; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Sprint should be between 0 and 100.");
            }
            sprint = value;
        }
    }

    public int Endurance
    {
        get { return endurance; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            endurance = value;
        }
    }

    internal double AverageStats()
    {
        double result = (this.Shooting + this.Passing + this.Sprint + this.Endurance + this.Dribble) / 5.0;
        return result;
    }

}

