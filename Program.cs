using System;

class RoseBlanches
{
    static void Main()
    {
        // Get the amount of money from the aunt
        Console.Write("How much did you receive money ($)? ");
        double totalAmount = double.Parse(Console.ReadLine());

        // Calculate the amount dedicated to books and supplies (three quarters)
        double booksAndSupplies = 0.75 * totalAmount;

        // Calculate the remaining amount for other expenses
        double remainingMoney = 0.25 * totalAmount;

        // Prices of coffee, Flash Computer, and subway ticket
        double coffeePrice = 2;
        double flashComputerPrice = 4;
        double subwayTicketPrice = 3;

        // Calculate the quantity for each expense
        int coffees = (int)(remainingMoney / coffeePrice);
        int flashComputers = (int)(remainingMoney / flashComputerPrice);
        int subwayTickets = (int)(remainingMoney / subwayTicketPrice);

        // Calculate the remaining amount for white roses
        double remainingForRoses = remainingMoney % coffeePrice;

        // Display the results
        Console.WriteLine($"Book and Supplies: {booksAndSupplies:C}");
        Console.WriteLine($"You can then buy:");
        Console.WriteLine($"{coffees} coffees");
        Console.WriteLine($"{flashComputers} Flash Computer Numbers");
        Console.WriteLine($"{subwayTickets} subway Tickets");
        Console.WriteLine($"and you will have {remainingForRoses:C} for the white roses.");
    }
}
