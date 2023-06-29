public class UserInterface
{
    private PersistenceManager persistenceManager = new PersistenceManager();
    private string goalsFilePath;

    public void ShowGoals(List<Goal> goals)
    {
        Console.WriteLine("Goals:");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"- {goal.Name}: {goal.Description}");
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

        // Prompt the user to provide the filename to save the goals
        Console.Write("Enter filename to save goals: ");
        goalsFilePath = Console.ReadLine();

        // Create the corresponding goal object based on user input
        Goal goal;
        Console.WriteLine("Choose the type of goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(name, description, points);
                break;
            case 2:
                goal = new EternalGoal(name, description, points);
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                Console.WriteLine();
                goal = new ChecklistGoal(name, description, points, targetCount, bonusPoints);
                break;
            default:
                throw new ArgumentException("Invalid goal type choice");
        }

        // Save the updated goals to the file
        List<Goal> goals = persistenceManager.LoadGoals(goalsFilePath);
        goals.Add(goal);
        persistenceManager.SaveGoals(goals, goalsFilePath);

        return goal;
    }

    public void RecordEvent(Goal goal)
    {
        int points = goal.RecordEvent();
        Console.WriteLine($"Event recorded for goal: {goal.Name}");
        Console.WriteLine($"Points earned: {points}");
        Console.WriteLine();

        // Prompt the user to provide the filename to save the goals
        Console.Write("Enter filename to save goals: ");
        goalsFilePath = Console.ReadLine();

        // Save the updated goals to the file
        List<Goal> goals = persistenceManager.LoadGoals(goalsFilePath);
        persistenceManager.SaveGoals(goals, goalsFilePath);
    }

    public void LoadGoals()
    {
        // Prompt the user to provide the filename to load the goals
        Console.Write("Enter filename to load goals: ");
        goalsFilePath = Console.ReadLine();

        List<Goal> goals = persistenceManager.LoadGoals(goalsFilePath);

        // Display the loaded goals
        ShowGoals(goals);
    }
}
