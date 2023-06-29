public class ChecklistGoal : Goal
{
    private int _completionCount = 0;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int completionCount, int targetCount, int bonusPoints) : base(name, description, points)
    {
        _completionCount = completionCount;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _completionCount++;
        if (_completionCount == _targetCount)
        {
            _completionCount = 0;
            return Points + _bonusPoints;
        }

        else
        {
            return Points;
        }
    }
    public override bool IsComplete()
    {
        return _completionCount == _targetCount;
    }
    
}