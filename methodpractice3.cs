using System;
class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("How much would you like to deposit?: ");
        double balance = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine("How much would you like to withdraw?: ");
        double request = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Withdraw(balance, request));
    }
    static string Withdraw(double balance, double request)
    {
        double newBalance = balance - request;
        if (balance < request)
        {
            return "Insufficient funds.";
        }
        else if (request <= 0)
        {
            return "Invalid Amount";
        }
        else
        {
            return $"Success! Your new balance is {newBalance}";
        }
    }
}