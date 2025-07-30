using System;

class TicketPriceCalculator
{
    // The main method where the program starts
    static void Main(string[] args)
    {
        // Ask the user to enter their age
        Console.Write("Enter your age: ");

        int age; // Variable to hold the user's age

        // Try to convert the user input to an integer
        bool isValid = int.TryParse(Console.ReadLine(), out age);

        // Check if the input was a valid number and not negative
        if (!isValid || age < 0)
        {
            Console.WriteLine("Invalid age input.");
            return; // Stop the program if input is not valid
        }

        // Check if the user is a child (12 or under) or a senior (65 or older)
        if (age <= 12 || age >= 65)
        {
            Console.WriteLine("Ticket price: GHC7"); // Discounted price
        }
        else
        {
            Console.WriteLine("Ticket price: GHC10"); // Regular price
        }

        // Pause the console so user can see the result
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
