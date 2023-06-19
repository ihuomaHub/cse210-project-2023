using System;

class Program
{
    static void Main(string[] args)
    {
       List<Shape> shapes = new List<Shape>();
       
       Circle circle = new Circle("Green", 5.0);
       Square square = new Square("Yellow", 6.0);
       Rectangle rectangle = new Rectangle("Blue", 10.0, 5.0);
       
       
       shapes.Add(square);
       shapes.Add(rectangle);
       shapes.Add(circle);

       foreach (Shape shape in shapes)
       {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
       }
    }
}