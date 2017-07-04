using System.Collections.Generic;

public class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public Trainer(string name, int badges)
    {
        this.Name = name;
        this.pokemons = new List<Pokemon>();
    }
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Badgeds
    {
        get { return this.badges; }
        set { this.badges = value; }
    }
    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = new List<Pokemon>(); }
    }
}