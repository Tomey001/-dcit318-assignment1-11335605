using System;

class TriangleTypeIdentifier
{
    // Main method starts the program
    static void Main(string[] args)
    {
        // Ask the user to enter the three sides of the triangle
        Console.WriteLine("Enter the three sides of a triangle:");

        double side1 = ReadSide("Side 1: ");
        double side2 = ReadSide("Side 2: ");
        double side3 = ReadSide("Side 3: ");

        // Check if the three sides can form a valid triangle
        // (sum of any two sides must be greater than the third side)
        if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        {
            // Check if all sides are equal
            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Triangle type: Equilateral");
            }
            // Check if any two sides are equal
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Triangle type: Isosceles");
            }
            // If all sides are different
            else
            {
                Console.WriteLine("Triangle type: Scalene");
            }
        }
        else
        {
            // Not a valid triangle based on the rule
            Console.WriteLine("The entered sides do not form a valid triangle.");
        }

        // Pause the console before exiting
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Helper method to read and validate a side length from the user
    static double ReadSide(string prompt)
    {
        double side;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && double.TryParse(input, out side) && side > 0)
            {
                return side;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}
