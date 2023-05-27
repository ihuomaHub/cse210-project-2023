using System;
public class UserInterface
{
    public static void DisplayScripture(Scripture scripture)
    {
        Console.WriteLine(scripture.GetFormattedText());
    }

    public static string GetUserInput()
    {
        return Console.ReadLine();
    }
    public static void ClearScreen()
    {
        Console.Clear();
    }
}