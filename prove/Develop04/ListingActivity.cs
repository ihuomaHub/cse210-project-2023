public class ListingActivity : Activity
{
    private string areaOfReflection;
    private List<string> promptOptions;
    private int itemCounter;
}

public void SetAreaOfReflection(string area)
{
    areaOfReflection = area;
}
public void AddPromptOption(string prompt)
{
    promptOptions.Add(prompt);
}
public void RemovePromptOption(string prompt)
{
    promptOptions.Remove(prompt);
}
public string GetRandomPrompt()
{
    return promptOptions[new Random().Next(promptOptions.Count)];
}

public void DisplayPrompt()
{
    Console.WriteLine("Listing Activity Prompt:");
}
public void RunActivity()
{
    StartActivity();
}