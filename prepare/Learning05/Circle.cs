public class Circle : Shape
{
    private double radius = 0;

    public Circle(string color, double Radius) : base(color)
    {
        radius = Radius;
    }
    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}