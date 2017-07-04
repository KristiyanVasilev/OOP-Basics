public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double x;
    private double y;

    public Rectangle(string id, double width, double height, double topLeftX, double topLeftY)
    {
        this.id = id;
        this.width = width;
        this.height = height;
        this.x = topLeftX;
        this.y = topLeftY; 
    }
    public bool Intersects(Rectangle rectangle)
    {
        if (this.x <= rectangle.x + rectangle.width && this.x + this.width >= rectangle.x &&
            this.y <= rectangle.y + rectangle.height && this.y + this.height >= rectangle.y)
        {
            return true;
        }
        return false;
    }
}

