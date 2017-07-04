public class Cargo
{
    private string cargoType;
    private int cargoWeight;

    public Cargo(int cargoWeight, string cargoType)
    {
        this.cargoWeight = cargoWeight;
        this.cargoType = cargoType;
    }
    public string CargoType
    {
        get { return this.cargoType; }
        set { this.cargoType = value; }
    }
}
