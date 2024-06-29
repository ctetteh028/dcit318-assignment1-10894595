using System;

class TicketPriceCalculator
{
    static void Main()
    {
        int age;

        // Prompt user to enter their age and validate input
        while (true)
        {
            Console.Write("Please enter your age: ");
            if (int.TryParse(Console.ReadLine(), out age) && age >= 0)
                break; // Valid age entered, exit the loop
            else
                Console.WriteLine("Invalid input. Please enter a valid age as a number.");
        }

        // Determine the ticket price based on age
        int ticketPrice;
        if (age >= 65 || age <= 12)
            ticketPrice = 7; // Senior citizens (65 and above) and children (12 and below) pay GHC7
        else
            ticketPrice = 10; // Regular price for others is GHC10

        // Display the ticket price
        Console.WriteLine($"The ticket price for age {age} is GHC{ticketPrice}");

        // Keep console window open until key press
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
