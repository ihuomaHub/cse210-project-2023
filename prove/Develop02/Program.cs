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

       options._userInput = Console.ReadLine();

       PromptQuestion question = new PromptQuestion();
       question._question1 = "If I had one thing I could do over today, what would it be? ";
       question._question2 = "What was the best part of my day? ";
       question._question3 = "What good have I done today? ";
       question._question4 = "What blessing am I grateful for today? ";
       question._question5 = "Who did I reach out today? ";

       PromptGenerator prompt = new PromptGenerator();
       prompt._prompt.Add(question);

       Journal entry = new Journal();
       entry._write = Console.ReadLine();
       



       options.display();

       options.displayMenuOptions();

       options.displayPrompt();

       

       prompt.displayPromptGenerator();

       entry.displayJournal();


    }
}