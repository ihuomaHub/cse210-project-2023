public class Menu
{
    public string _welcomeNote;
    public string _menuPrompt;

    public string _userResponse;
    
    public List<MenuOptions> _menuOptions  = new List<MenuOptions>();
    public string _promptGenerator;

    
    public void DisplayWecomeNote()
    {
        Console.WriteLine();
        Console.WriteLine($"{_welcomeNote}");
        Console.WriteLine();
    }

    public void Display()
        
    {
        foreach (MenuOptions option in _menuOptions)
        {
            Console.WriteLine("Please select one of these choices:");
            option.Display();

        }
        Console.Write("What would you like to do? ");
        

    }

}