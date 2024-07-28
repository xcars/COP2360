using System;

class Hurricane
{
    static void Main()
    {
        Console.WriteLine("Enter the wind speed of the storm:");
        string input = Console.ReadLine();
        double windSpeed;

        if (double.TryParse(input, out windSpeed))
        {
            string category = "Not a Huricane";

            if (windSpeed >= 157)
                category = "Category 5 Hurricane";
            else if (windSpeed >= 130)
                category = "Category 4 Hurricane";
            else if (windSpeed >= 111)
                category = "Category 3 Hurricane";
            else if (windSpeed >= 96)
                category = "Category 2 Hurricane";
            else if (windSpeed >= 74)
                category = "Category 1 Hurricane";

            Console.WriteLine(category);
        }
        else
        {
            Console.WriteLine("Error, please try again.");
        }
    }
}