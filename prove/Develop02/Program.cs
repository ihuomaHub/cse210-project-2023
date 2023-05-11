using System;

class Program
{
    static void Main(string[] args)
    {
       Menu options = new Menu();
       options._write = "Write";
       options._display = "Display";
       options._load = "Load";
       options._save = "Save";
       options._quit = "Quit";

       

       options.displayWelcomeNote();

       options.displayMenuOptions();

       Entry prompt = new Entry();
       
       prompt._menuPrompt = Console.ReadLine();

       prompt.displayMenuPrompt();


    }
}