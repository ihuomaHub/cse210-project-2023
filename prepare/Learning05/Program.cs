using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Yellow", 5.0);

        Rectangle rectangle = new Rectangle("Blue", 10.0, 5.0);

        DisplayShapeInformation(square);
        DisplayShapeInformation(rectangle);
    }
    public static void DisplayShapeInformation(Shape shape)
    {
        Console.WriteLine($"{shape.GetColor()}");

        double area = shape.GetArea();
        Console.WriteLine($"Area: {area}");
    }
}