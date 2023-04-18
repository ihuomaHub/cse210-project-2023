using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = " ";
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int X = int.Parse(userInput);
        if (X >= 90)
        {
            letter = "A";
        }
        else if (X >= 80 && X < 90)
        {
            letter = "B";
        }
        else if (X >= 70 && X < 80)
        {
            letter = "C";
        }
        else if (X >= 60 && X < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade score is {letter}");

        if (X >= 70)
        {
            Console.WriteLine("Congratulations! You PASSED the class");
        }
        else
        {
            Console.WriteLine("FAILED! Work hard to PASS the class next time.");
        }
    }
}