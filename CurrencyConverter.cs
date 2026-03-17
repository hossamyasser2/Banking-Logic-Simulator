using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an amount in KWD: ");
        double kwd = Convert.ToDouble(Console.ReadLine());
        double kwdToUsd = kwd * 3.26;
        double kwdToGbp = kwd * 2.44;
        bool valid = true;
        Console.WriteLine("Would you like to convert it to USD or GBP? ");
        string currencyConversion = Console.ReadLine().ToUpper();
        while (valid)
        {
            if (currencyConversion == "USD")
            {
                Console.WriteLine($"Result: {kwdToUsd}");
                return;
            }
            else if (currencyConversion == "GBP")
            {
                Console.WriteLine($"Result: {kwdToGbp}");
                return;
            }
            else
            {
                Console.WriteLine("Please pick from the options. Would you like to convert it to USD or GBP? ");
                currencyConversion = Console.ReadLine().ToUpper();
            }

        }

    }
}


    