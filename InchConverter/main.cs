using System;

    class InchesToCentimeterslnteractive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("InchesToCentimeters");

            const double centimetersPerInch = 2.54;
            double Inches = 0;
            double Result = 0;

            Console.Write("Input inches:");

            Inches = double.Parse(Console.ReadLine());
            Result = Inches * centimetersPerInch;

            Console.WriteLine($"{Inches} inches is {Result} centimeters.");

        }
    }