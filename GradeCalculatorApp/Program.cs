using System;

class GradeCalculator
{
    // This is the main method where the program starts
    static void Main(string[] args)
    {
        // Ask the user to enter their grade between 0 and 100
        Console.Write("Enter your grade (0 - 100): ");
        
        int grade; // Variable to store the user's grade

        // Try to convert the input to an integer
        bool isValid = int.TryParse(Console.ReadLine(), out grade);

        // Check if input is a valid number and within the right range
        if (!isValid || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            return; // Exit the program early if input is invalid
        }

        // Use if-else statements to determine the letter grade
        if (grade >= 90)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is: D");
        }
        else
        {
            Console.WriteLine("Your grade is: F");
        }

        // Pause the console (optional for some environments)
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
