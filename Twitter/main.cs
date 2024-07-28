using System;

class Twitter
{
    static void Main()
    {
        Console.WriteLine("Twitter");

        Console.Write("Enter your message: ");
        string message = Console.ReadLine();

        string result = ValidateTweet(message);
        Console.WriteLine(result);
    }

    static string ValidateTweet(string message)
    {
        if (message.Length <= 140)
        {
            return "Posted.";
        }
        else
        {
            return "Rejected.";
        }
    }
}