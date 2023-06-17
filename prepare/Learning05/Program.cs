using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Yellow", 5.0);

        Rectangle rectangle = new Rectangle("Blue", 10.0, 5.0);

        Circle circle = new Circle("Green", 5.0);

        DisplayShapeInformation(square);
        DisplayShapeInformation(rectangle);
        DisplayShapeInformation(circle);
    }
    public static void DisplayShapeInformation(Shape shape)
    {
        string shapeName = shape.GetType().Name;
        Console.WriteLine($"shape: {shapeName}");

        string color = shape.GetColor();
        Console.WriteLine($"Color: {color}");

        double area = shape.GetArea();
        Console.WriteLine($"Area: {area}");
    }
}