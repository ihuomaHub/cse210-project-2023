public class Shape
{
    protected string color;

    public string GetColor()
    {
        return color;
    }
    public void SetColor(string value)
    {
        color = value;
    }
    public virtual double GetArea()
    {
        return 0;
    }

}