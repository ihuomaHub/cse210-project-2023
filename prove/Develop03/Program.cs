using System;

public class Program
{
    public static void Main(string[] args)
    
    {
        Console.WriteLine("WELCOME TO SCRIPTURE MEMORIZER PROGRAM!");
        Console.WriteLine ("---------------------------------------");
        Console.WriteLine("CSC 210: Week 06 Prove: Developer");
        Console.WriteLine("Created by: John Ihuoma Anochirionye");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
        //Reference object is created here
        Reference reference = new Reference( "John", 3, 16, 17);

        //Scripture object is created here
        string scriptureText = 
        "For God so loved the world, " +
        "that he gave his only begotten son, " +  
        "that whosoever believeth in him should not perish, " + 
        "but have everlasting life.; " +
        "For God sent not his Son into the world to condemn " +
        "the world but through him might be saved. ";

        Scripture scripture = new Scripture(reference, scriptureText);
        //Initial scripture is display here
        Console.WriteLine(scripture.GetFormattedText());

        Console.WriteLine("Program Instruction:");
        Console.WriteLine();

        //The user is prompted to press enter key to continue or type 'quit' to finish.
        Console.WriteLine("Press enter to continue or type 'quit' to finish.");
        string input = Console.ReadLine();

        //The program continue hiding random words untill all words are hidden or the user type 'quit' to finish

    

        while (!scripture.IsCompletelyHidden() && input.ToLower() != "quit")
        {
            //Random word is hidden
            scripture.HideRandomWord();

            //Console screen is cleared
            Console.Clear();

            //Updated scripture is displayed
            Console.WriteLine(scripture.GetFormattedText());

            //The user is prompted again
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            input = Console.ReadLine();
        }
    }

}