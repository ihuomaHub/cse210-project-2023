using System;
public class UserInterface
{
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static string GetUserInput()
    {
        return Console.ReadLine();
    }
}