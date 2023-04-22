using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number = -1;
        List<int> numbers = new List<int>();
        

        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }while(number!= 0);

        Console.WriteLine(numbers.Count);

        int sumOfTotal = numbers.Sum();

        double averNumber = (double)numbers.Average();

        int largestNumber = numbers.Max();
        
        Console.WriteLine($"The Sum is: {sumOfTotal}");

        Console.WriteLine($"The average number is: {averNumber}");

        Console.WriteLine($"The largest number is: {largestNumber}");

        

        

        
    }
}