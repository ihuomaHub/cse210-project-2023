public abstract class Goal 
{
    private string name;
    private string description;
    private int points;

    public Goal(string name, string description, int points)
    {
        this.name = name;
        this.description = description;
        this.points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();    
    
}