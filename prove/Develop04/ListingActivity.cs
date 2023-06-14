using System;
using System.Collections.Generic;

public class ListingActivity : Mindfullness
{
    protected string areaOfReflection;
    protected List<string> promptOptions;
    protected int itemCounter;

    public ListingActivity()
    {
        ActivityName = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
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
        Random random = new Random();
        return promptOptions[random.Next(promptOptions.Count)];
    }

    public override void RunActivity()
    {
        base.RunActivity();

        DisplayPrompt();
        PauseWithSpinner(2);

        itemCounter = 0;
        while (itemCounter < Duration)
        {
            Console.WriteLine("Enter an item for reflection:");
            string item = Console.ReadLine();
            itemCounter++;
        }

        Console.WriteLine("Number of items entered: {0}", itemCounter);
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Listing Activity Prompt:");
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
}
