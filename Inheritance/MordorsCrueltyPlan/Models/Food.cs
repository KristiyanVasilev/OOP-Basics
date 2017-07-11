public abstract class Food
{
    public int HappinesPoints { get; set; }
    protected Food(int happinesPoints)
    {
        this.HappinesPoints = happinesPoints;
    }
    public int GetHapinessPoints()
    {
        return this.HappinesPoints;
    }
}

