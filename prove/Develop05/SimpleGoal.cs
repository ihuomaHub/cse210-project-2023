public class SimpleGoal : Goal
{
    private bool completionStatus;
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        completionStatus = false;
    }

    public override int RecordEvent()
    {
        completionStatus = true;
        return points;
    }

    public override bool IsComplete()
    {
        return completionStatus;
    }
}