public class ChecklistGoal : Goal
{
    private int completionCount = 0;
    private int targetCount;
    private int bonusPoints;

    public ChecklistGoal(string name, string description, int points, int completionCount, int targetCount, int bonusPoints) : base(name, description, points)
    {
        this.completionCount = completionCount;
        this.targetCount = targetCount;
        this.bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        completionCount++;
        if (this.completionCount == this.targetCount)
        {
            this.completionCount = 0;
            return Points + this.bonusPoints;
        }

        else
        {
            return Points;
        }
    }
    public override bool IsComplete()
    {
        return this.completionCount == this.targetCount;
    }
    
}