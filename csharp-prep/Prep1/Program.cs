using System;

class Program
{
    static void Main(string[] args)
    {   // Ask User of their first and Last Name and display: Last name, first name, last name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is {lastName}, {firstName}, {lastName}.");
    }
}