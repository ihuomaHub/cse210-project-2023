using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int userGuess = -1;
        
        do
        {
            Console.Write("Guess the number: ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("higher");
            }
                
            else
            {
                Console.WriteLine("Correct! You guessed it!");
            } 
        }while (userGuess != magicNumber);
        
    }
}