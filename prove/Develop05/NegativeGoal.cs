public class NegativeGoal : Goal
{
    private int _negativePoints;
    public NegativeGoal(string name, string description, int negativePoints) : base(name, description, 0)
    {
        _negativePoints = negativePoints;
    }

    public override int RecordEvent()
    {
        return _negativePoints;
    }

    public override bool IsComplete()
    {
        return false;
    }
}