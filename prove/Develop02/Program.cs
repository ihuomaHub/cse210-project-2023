using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        MenuOptions options = new MenuOptions();
        options._write = "1. Write";
        options._display = "2. Display";
        options._load = "3. Load";
        options._save = "4. Save";
        options._quit = "5. Quit";

        RandomPromptGenerator promptGenerator = new RandomPromptGenerator();
        
        
        List<JournalEntry> journalEntries = new List<JournalEntry>();
        

        Menu menu1 = new Menu();
        menu1._welcomeNote = "WELCOME TO THE JOURNAL PROGRAM!";
        menu1._menuOptions.Add(options);
        
        menu1.DisplayWecomeNote();

        while (true)
        {
            menu1.Display();
            menu1._userResponse = Console.ReadLine();

            if (menu1._userResponse == "1")
            {
                string randomPrompt = promptGenerator.GenerateRandomPrompt();
                Console.WriteLine(randomPrompt);
                string response = Console.ReadLine();
                DateTime entryDate = DateTime.Now;
                JournalEntry newEntry = new JournalEntry ();
                newEntry._entryDate = entryDate;
                newEntry._randomPrompt = randomPrompt;
                newEntry._response = response;
                journalEntries.Add(newEntry);
            }
            else if (menu1._userResponse == "2")
            {
                DisplayAllJournalEntries(journalEntries);
                Console.ReadLine();
            }
            else if (menu1._userResponse != "1" && menu1._userResponse !="2")
            {
                break;
            }
        }
        
    }
    static void DisplayAllJournalEntries(List<JournalEntry> entries)
    
    {
        Console.WriteLine("All Journal Entries");
        foreach (JournalEntry entry in entries)
        {
            Console.WriteLine($"Entry Date: {entry._entryDate.ToString()}");
            Console.WriteLine($"Prompt Question: {entry._randomPrompt}");
            Console.WriteLine($"Response: {entry._response}");
            Console.WriteLine();
        }
    }
}

    
