public class Square : Shape
{
    protected double _sideLength = 0;
    public Square(string color, double sideLength) : base(color)
    {
         _sideLength = sideLength;
    }
  
    public override double GetArea()
    {
        return _sideLength * _sideLength;
    }
}