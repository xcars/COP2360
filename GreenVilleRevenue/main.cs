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
                Console.WriteLine("Thank you for using the Greenvile Revenue App, Good-bye!");
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

        int revenue = FEE * numThisYearContestants;
        bool isBigger = numThisYearContestants > numLastYearContestants;

        Console.WriteLine("Last year's competition had " + numLastYearContestants + " contestants, and this year's has " + numThisYearContestants + " contestants.");
        Console.WriteLine("Revenue expected this year is $" + revenue + ".");
        Console.WriteLine("It is " + isBigger + " that this year's competition is bigger than last year's.");
    }
}