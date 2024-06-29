class TriangleTypeIdentifier
{
    static void Main()
    {
        double side1, side2, side3;

        // Prompt user to enter the lengths of the sides of the triangle and validate input
        while (true)
        {
            Console.Write("Enter the length of the first side of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out side1) && side1 > 0)
                break; // Valid side length entered, exit the loop
            else
                Console.WriteLine("Invalid input. Please enter a valid positive number for the side length.");
        }

        while (true)
        {
            Console.Write("Enter the length of the second side of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out side2) && side2 > 0)
                break; // Valid side length entered, exit the loop
            else
                Console.WriteLine("Invalid input. Please enter a valid positive number for the side length.");
        }

        while (true)
        {
            Console.Write("Enter the length of the third side of the triangle: ");
            if (double.TryParse(Console.ReadLine(), out side3) && side3 > 0)
                break; // Valid side length entered, exit the loop
            else
                Console.WriteLine("Invalid input. Please enter a valid positive number for the side length.");
        }

        // Determine the type of triangle based on side lengths
        if (side1 == side2 && side2 == side3)
            Console.WriteLine("The triangle is an Equilateral triangle.");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("The triangle is an Isosceles triangle.");
        else
            Console.WriteLine("The triangle is a Scalene triangle.");

        // Keep console window open until key press
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
