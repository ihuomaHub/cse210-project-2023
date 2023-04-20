using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 0;

        int userGuess = -1;
        
        do
        {
            Console.Write("What is the magic number? ");
            magicNumber = int.Parse(Console.ReadLine());
           
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