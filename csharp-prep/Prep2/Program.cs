using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int X = int.Parse(userInput);

        if (X >= 90)
        {
            Console.WriteLine("Your grade score is A!");
        }
        else if (X >= 80 && X < 90)
        {
            Console.WriteLine("Your grade score is B!");
        }
        else if (X >= 70 && X < 80)
        {
            Console.WriteLine("Your grade score is C!");
        }
        else if (X >= 60 && X < 70)
        {
            Console.WriteLine("Your grade score is D!");
        }
        else
        {
            Console.WriteLine("Your grade score is F!");
        }

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