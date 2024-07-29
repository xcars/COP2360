using System;

class HomeSales
{
    static void Main(string[] args)
    {
        double dSum = 0;
        double eSum = 0;
        double fSum = 0;

        Console.WriteLine("====Enter Z to Finalize Totals====");

        while (true)
        {
            Console.Write("Which Salesperson? : ");
            char in_who = char.ToUpper(Console.ReadLine()[0]);

            if (in_who == 'Z')
                break;

            if (in_who == 'D')
            {
                Console.Write("D: Enter Sale: ");
                dSum += double.Parse(Console.ReadLine());
            }
            else if (in_who == 'E')
            {
                Console.Write("E: Enter Sale: ");
                eSum += double.Parse(Console.ReadLine());
            }
            else if (in_who == 'F')
            {
                Console.Write("F: Enter Sale: ");
                fSum += double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("intermediate output: Error, invalid salesperson selected, please try again");
            }
        }
        Console.WriteLine("===================");
        Console.WriteLine("Grand Total: {0}", dSum + eSum + fSum);

        if (dSum > eSum && dSum > fSum)
            Console.WriteLine("Highest Sale: D");
        else if (eSum > dSum && eSum > fSum)
            Console.WriteLine("Highest Sale: E");
        else if (fSum > dSum && fSum > eSum)
            Console.WriteLine("Highest Sale: F");
    }
}