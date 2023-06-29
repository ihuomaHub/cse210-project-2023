public class UserInterface
{
    public void ShowGoals(List<Goal> goals)
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"- {goal.name}: {goal.description}");
        }
        Console.WriteLine();
    }

    public void ShowScore(int score)
    {
        Console.WriteLine($"Score: {score}");
        Console.WriteLine();
    }

    public Goal CreateGoal()
    {
        Console.WriteLine("Create a new goal: ");
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //User is prompted for goal type and create the corresponding goal object
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                return new SimpleGoal(name, description, points);
            case 2:
                return new EternalGoal(name, description, points);
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                Console.WriteLine();
                return new ChecklistGoal(name, description, points, targetCount, bonusPoints);
            default:
                throw new ArgumentException("Invalid goal type choice");
        }
    }

    public void RecordEvent(Goal goal)
    {
        int points = goal.RecordEvent();
        Console.WriteLine($"Event recorded for goal: {goal.name}");
        Console.WriteLine($"Points earned: {points}");
        Console.WriteLine();
    }
}