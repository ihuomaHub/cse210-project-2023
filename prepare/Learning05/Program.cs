using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Yellow", 5.0);
        square.SetColor("Blue");
        
        string color = square.GetColor();
        double area = square.GetArea();
        
        Console.WriteLine($"Color: {color}, Area: {area}");

    }
}