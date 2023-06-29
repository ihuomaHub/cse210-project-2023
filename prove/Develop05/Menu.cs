public class Menu
{
    private List<Goal> goals;
    private int score;
    private UserInterface userInterface;

    public Menu()
    {
        goals = new List<Goal>();
        score = 0;
        userInterface = new UserInterface();
    }

    public void DisplayMenu()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Goal newGoal = userInterface.CreateGoal();
                    goals.Add(newGoal);
                    break;
                case 2:
                    userInterface.ShowGoals(goals);
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    Console.Write("Enter the index of the goal to record an event: ");
                    int index = int.Parse(Console.ReadLine());
                    if (index >= 0 && index < goals.Count)
                    {
                        Goal goal = goals[index];
                        userInterface.RecordEvent(goal);
                        score += goal.RecordEvent();
                    }
                    else
                    {
                        Console.WriteLine("Invalid goal index");
                    }
                    break;
                case 6:
                    quit = true;
                    break;
                //defualt:
                   // Console.WriteLine("Invalid menu choice");
                   // break;
            }

            userInterface.ShowScore(score);
        }
    }

    public void SaveGoals()
    {
        //Goal is saved to a file 
        Console.WriteLine("Goal Saved.");
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        //Load goal from a file
        Console.WriteLine("Goals loaded.");
        Console.WriteLine();
    }
}