using System;

class MoveEstimator
{
    static void Main(string[] args)
    {
        Console.WriteLine("MoveEstimator");

        const double baseRate = 200;
        const double hourRate = 150;
        const double mileRate = 2; 

        Console.Write("Estimated Hours: ");
        double inputHours = double.Parse(Console.ReadLine());

        Console.Write("Estimated Miles: ");
        double inputMiles = double.Parse(Console.ReadLine());

        double calculatedEstimate = baseRate + (hourRate * inputHours) + (mileRate * inputMiles);

        Console.WriteLine($"${calculatedEstimate}");
    }
}