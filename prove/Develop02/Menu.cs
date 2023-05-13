public class Menu
{
    public string _write;
    public string _display;
    public  string _load;
    public string _save;
    public string _quit;

    //ublic string _menuPrompt = "userInput";

    public void display()
    {
        Console.WriteLine("WELCOME TO THE JOURNAL PROGRAM!");
    }

    public void displayMenuOptions()
    {
        Console.WriteLine("Please select one of the following choices;");
        Console.WriteLine($"1. {_write}");
        Console.WriteLine($"2. {_display}");
        Console.WriteLine($"3. {_load}");
        Console.WriteLine($"4. {_save}");
        Console.WriteLine($"5. {_quit}");

    }

    public void displayPrompt()
    {
        Console.Write($"What would you like to do? ");
        string userInput = Console.ReadLine();
    }
    
}
