public class Fraction
{
    public int _top;
    public int _bottom;

    public void displayFraaction()
    {
        Console.WriteLine($"{_top} / {_bottom}");
    }

    /*public class Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public class Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public class Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public int SetTop(int top)
    {
        _top = top;
        return top;
    }
    
    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottom)
    {
        _bottom = bottom;
        return bottom;
    }
    */
}