using System.Collections.Generic;

public class Person
{
    //private string name;
    //private string company;
    //private string car;
    //private List<Parent> parents;
    //private List<Children> childres;
    //private List<Pokemon> pokemons;

    public Person(string name)
    {
        this.Name = name;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Parent>();
        this.Children = new List<Children>();
    }   
    public string Name { get; set; }
    public Company Company { get; set; }
    public Car Car { get; set; }
    public List<Parent> Parents { get; set; }
    public List<Children> Children { get; set; }
    public List<Pokemon> Pokemons { get; set; }

}