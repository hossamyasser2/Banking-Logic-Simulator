using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---Welcome to Secure ATM Machine---");
        int pinCode = 8965;
        int attempts = 3;
        while (true)
        {
            Console.WriteLine("Please enter your PIN. ");
            int userEntry = Convert.ToInt32(Console.ReadLine());
            attempts--;
            if (userEntry == pinCode)
            {
                Console.WriteLine("Login Succesful.");
                break;
            }
            else if (attempts == 0)
            {
                Console.WriteLine("You have been locked out.");
                break;
            }
            Console.WriteLine($"Incorrect PIN.");
            Console.WriteLine($"You have {attempts} attempts remaining.");
        }

    }
}