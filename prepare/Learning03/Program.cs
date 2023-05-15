using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.GetTop();
        fraction.GetBottom();
        fraction.SetTop(1);
        fraction.SetBottom(3);

        fraction.displayFractionalString();   

        fraction.displayDecimalValue();  
    }
}