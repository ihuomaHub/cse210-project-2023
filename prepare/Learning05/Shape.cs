public abstract class Shape
{
    protected string color;

    public Shape(string Color)
    {
         color = Color;
    }
    public virtual string GetColor()
    {
        return color;
    }
    public virtual double GetArea()
    {
        return 0;
    }

}