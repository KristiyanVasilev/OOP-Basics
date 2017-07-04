public class Car
{
    private string model;
    private Engine engine;
    private int weight;
    private string color;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }
    public int Weight
    {
        get { return this.weight; }
        set { this.weight = value; }
    }
    public string Color
    {
        get { return this.color; }
        set { this.color = value; }
    }

    public Car(string model, Engine engine)
    {
        this.Engine = engine;
        this.Model = model;
        this.Color = "n/a";
    }
    public Car(string model, Engine engine, int weight)
      : this(model, engine)
    {
        this.Weight = weight;
        this.Color = "n/a";
    }
    public Car(string model, Engine engine, string color)
      : this(model, engine)
    {
        this.Color = color;
    }   
}