using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        Console.Write("Guess the number: ");
        string guess = Console.ReadLine();
        int number = int.Parse(input);
        int userGuess = int.Parse(guess);

        if (userGuess > number)
        {
            Console.WriteLine("Lower");
        }
        else if (userGuess < number)
        {
            Console.WriteLine("higher");
        }
        else
        {
            Console.WriteLine("You guess it!");
        }
    }
}