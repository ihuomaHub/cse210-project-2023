public class PersistenceManager
{
    public void SaveGoals(List<Goal> goals, string filePath)
    {
        // Implement the code to save the goals to the specified file
        // Example code:
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.Name},{goal.Description},{goal.Points}");
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public List<Goal> LoadGoals(string filePath)
    {
        List<Goal> goals = new List<Goal>();
        // Implement the code to load goals from the specified file
        
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] goalData = line.Split(',');
                if (goalData.Length == 3)
                {
                    string name = goalData[0];
                    string description = goalData[1];
                    int points = int.Parse(goalData[2]);

                    // Create a new goal object based on the loaded data
                    Goal goal = new SimpleGoal(name, description, points);

                    goals.Add(goal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully.");
        return goals;
    }
}
