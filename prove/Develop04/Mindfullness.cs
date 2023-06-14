using System;
using System.Threading;

public class Activity
{
    public string ActivityName { get; protected set; }
    public string Description { get; protected set; }
    public int Duration { get; protected set; }

    public virtual void RunActivity()
    {
        DisplayStartingMessage();
        PauseWithSpinner(3);
        Console.WriteLine("Prepare to begin...");
        PauseWithSpinner(2);
        Console.WriteLine("Activity started!");
        PauseWithSpinner(Duration);
        Console.WriteLine("Activity ended!");
        DisplayEndingMessage();
        PauseWithSpinner(3);
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine("========== {0} ==========", ActivityName);
        Console.WriteLine(Description);
        Console.WriteLine("Enter the duration in seconds:");
        while (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a valid duration in seconds:");
        }
        Duration = duration;
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job! You have completed the {0} activity.", ActivityName);
        Console.WriteLine("Duration: {0} seconds", Duration);
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}