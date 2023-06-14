using System;

public class Program
{
    static void Main(string[] args)
    {
        // Instantiate the activities
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        // Create a menu system
        int choice;
        do
        {
            Console.WriteLine("========== Mindfulness App ==========");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("=====================================");

            Console.WriteLine("Please enter your choice (1-4):");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please enter a valid choice (1-4):");
            }

            switch (choice)
            {
                case 1:
                    // Run the breathing activity
                    breathingActivity.RunActivity();
                    break;
                case 2:
                    // Run the reflection activity
                    reflectionActivity.RunActivity();
                    break;
                case 3:
                    // Run the listing activity
                    listingActivity.RunActivity();
                    break;
                case 4:
                    // Quit the program
                    Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                    break;
            }

        } while (choice != 4);
    }
}
