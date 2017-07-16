using Minedraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{    
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private HarvesterFactory harvesterFactory;
    private ProviderFactory providerFactory;

    public DraftManager()
    {
        this.harvesterFactory = new HarvesterFactory();
        this.providerFactory = new ProviderFactory();
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            this.harvesters.Add(this.harvesterFactory.Get(arguments));
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }
        return $"Successfully registered {arguments[0]} Harvester - {arguments[1]}";

    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            this.providers.Add(this.providerFactory.Get(arguments));
        }
        catch (ArgumentException ae)
        {
            return ae.Message;
        }

        return $"Successfully registered {arguments[0]} Provider - {arguments[1]}";
    }
    public string Day()
    {
        double neededEnergy = 0;
        double summedOreOutput = 0;
        double providedEnergy = this.providers.Sum(p => p.EnergyOutput);
        this.totalStoredEnergy += providedEnergy;
        switch (this.mode)
        {
            case "Full":
                neededEnergy = this.harvesters.Sum(s => s.EnergyRequirement);
                if (this.totalStoredEnergy >= neededEnergy)
                {
                    summedOreOutput = this.harvesters.Sum(h => h.OreOutput);
                    this.totalMinedOre += summedOreOutput;
                    this.totalStoredEnergy -= neededEnergy;
                }
                break;

            case "Half":
                neededEnergy = this.harvesters.Sum(s => s.EnergyRequirement) * 0.60;
                if (this.totalStoredEnergy >= neededEnergy)
                {
                    summedOreOutput = this.harvesters.Sum(h => h.OreOutput) * 0.50;
                    this.totalMinedOre += summedOreOutput;
                    this.totalStoredEnergy -= neededEnergy;
                }
                break;

            case "Energy":
                break;
        }
        var sb = new StringBuilder();
        sb.AppendLine("A day has passed.");
        sb.AppendLine($"Energy Provided: {providedEnergy}");
        sb.Append($"Plumbus Ore Mined: {summedOreOutput}");

        return sb.ToString();
    }
    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {arguments[0]} Mode";
    }
    public string Check(List<string> arguments)
    {
        var id = arguments[0];
        if (this.harvesters.Any(x => x.Id == id))
        {
            return this.harvesters.FirstOrDefault(x => x.Id == id).ToString();
        }
        else if (this.providers.Any(x => x.Id == id))
        {
            return this.providers.FirstOrDefault(x => x.Id == id).ToString();
        }
        else
        {
            return $"No element found with id - {id}";
        }
    }
    public string ShutDown()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalStoredEnergy}");
        sb.Append($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        return sb.ToString();
    }
}

