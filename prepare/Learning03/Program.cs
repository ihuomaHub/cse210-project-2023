using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        fraction.GetTop();
        fraction.GetBottom();
        fraction.SetTop(5);
        fraction.SetBottom(5);

        fraction.displayFractionalString(); 

        fraction.displayDecimalValue(); 

       
    }
}