using System.Collections.Generic;

public class Person
{
    private string name;
    private int age;
    private List<Person> people;

    public List<Person> People
    {
        get { return this.people; }
        set { this.people = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }
    public Person(int age)
    {
        this.name = "No name";
        this.age = age;
    }
    public Person(int age, string name)
    {
        this.name = name;
        this.age = age;
    }
    public Person(List<Person> people)
    {

    }
}

