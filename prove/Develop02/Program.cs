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

       
      
       

       RandomQuestions questions = new RandomQuestions();
       questions._promptQuestion1 = "What was the best part of my day";
       questions._promptQuestion2 = "If there is something you need to change today, what will that be?";
       questions._promptQuestion3 = "What kind act did I exhibit today?";
       questions._promptQuestion4 = "What shall I be grateful for today?";
       questions._promptQuestion5 = "What service did I render today?";


       options.display();

       options.displayMenuOptions();

       options.displayPrompt();

       //questions.displayRandomQuestions();


    }
}