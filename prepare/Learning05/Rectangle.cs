public class Rectangle : Shape
{
    private double length = 0;
    private double width = 0;

    public Rectangle(string color, double Length, double Width) : base(color)
    {
        length = Length;
        width = Width;
    }

    public override double GetArea()
    {
        return length * width;
    }
}