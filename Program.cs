using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("---Welcome To Secure Bank Terminal---");
        Console.WriteLine("Enter Customer Full Name:");
        string fullName = Console.ReadLine();
        
        Console.WriteLine("Enter Initial Deposit Amount:");
        double balance = Convert.ToDouble(Console.ReadLine());
        double interestRate = 0.05;
        double balanceInTenYears = balance * Math.Pow(1 + interestRate, 10);
        
        string accountID = fullName.Substring(0,3).ToUpper() + "-" + balance.ToString().Length;
        
        Random random = new Random();
        int generatedOTP = random.Next(1000, 9999);

        Console.WriteLine("SECURITY: A temporary PIN has been generated: " + generatedOTP);
        Console.WriteLine("Please confirm PIN to view projected balance.");
        int userEntry = Convert.ToInt32(Console.ReadLine());
        if(userEntry == generatedOTP)
        {
            Console.WriteLine("VERIFIED.");
            Console.WriteLine("Account Holder: "+ fullName.ToUpper());
            Console.WriteLine("Account ID: " + accountID);
            Console.WriteLine("Current Balance: " + balance);
            Console.WriteLine("Balance in 10 years: " + balanceInTenYears);
        }
        else
        {
            Console.WriteLine("ACCESS DENIED: Unauthorized PIN entry.");
        }
        
        Console.WriteLine("Press any key to logout.");
        Console.ReadKey();
    }

}