using System;
using System.Text;

public abstract class Provider
{
    private string id;
    private double energyOutput;

    public Provider(string id, double energyOutput)
    {
        this.Id = id;
        this.EnergyOutput = energyOutput;
    }

    public string Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public double EnergyOutput
    {
        get { return this.energyOutput; }
        protected set
        {
            if (value < 0 || value > 10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's EnergyOutput");
            }
            this.energyOutput = value;
        }
    }
    public override string ToString()
    {
        var sb = new StringBuilder();
        var name = this.GetType().Name;
        var index = name.IndexOf("Provider");
        name = name.Insert(index, " ");
        sb.AppendLine($"{name} - {this.Id}");
        sb.Append($"Energy Output: {this.EnergyOutput}");
        return sb.ToString();
    }
}

