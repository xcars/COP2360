using System;

class GreenvilleRevenue
{
    const int FEE = 25;
    static int numLastYearContestants, numThisYearContestants;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("*  The stars shine at Greenville   *");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1. Calculate Greenville revenue year-over-year");
            Console.WriteLine("2. Exit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                CalculateRevenueAndCompare();
            }
            else if (choice == "2")
            {
                Console.WriteLine("Thank you for using the Greenville Revenue App. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }

    static void CalculateRevenueAndCompare()
    {
        Console.Write("Enter number of contestants from last year's contest: ");
        numLastYearContestants = int.Parse(Console.ReadLine());

        Console.Write("Enter number of contestants this year: ");
        numThisYearContestants = int.Parse(Console.ReadLine());

        if (numThisYearContestants > 2 * numLastYearContestants)
        {
            Console.WriteLine("The competition is more than twice as big this year!");
        }
        else if (numThisYearContestants > numLastYearContestants)
        {
            Console.WriteLine("The competition is bigger than ever!");
        }
        else
        {
            Console.WriteLine("A tighter race this year! Come out and cast your vote!");
        }
    }
}