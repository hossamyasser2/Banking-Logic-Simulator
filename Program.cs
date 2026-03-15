using System; 

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("---Welcome To Secure Bank Terminal---"); // Welcome text
        Console.WriteLine("Enter Customer Full Name:"); // Asks user to input their full name
        string fullName = Console.ReadLine(); // Retrieves the users input into variable
        if (string.IsNullOrWhiteSpace(fullName))
        {
            Console.WriteLine("Please Enter Customer Full Name:");
        }
        else
        {
        Console.WriteLine("Thank you for entering your name.");
        }
        
        Console.WriteLine("Enter Initial Deposit Amount:"); // Asks the user to input the deposit amount.
        string balanceInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(balanceInput))
        {
            Console.WriteLine("Please enter a deposit amount.");
            return;
        }
        double balance = Convert.ToDouble(balanceInput); // Converts users input into double
        Console.WriteLine("Thank you for entering a deposit amount.");
        double interestRate = 0.05; // Interest rate
        double balanceInTenYears = balance * Math.Pow(1 + interestRate, 10); // Calculates balance in 10 years by taking original balance 
                                                                            // and multiplying it by the interest rate + 1 to the power of 10
        string accountID = fullName.Substring(0,3).ToUpper() + "-" + balance.ToString().Length; // Stores the users first 3 letters of their name and makes it UPPERCASE and 
                                                                                               // adds a - then converst the balance into a string and calculates the number of characters the balance has
        Random random = new Random(); // Random number generator
        int generatedOTP = random.Next(1000, 9999); // From 1000-9999 Random number

        Console.WriteLine("SECURITY: A temporary PIN has been generated: " + generatedOTP); // Tells the user the generated PIN
        Console.WriteLine("Please confirm PIN to view projected balance."); // Asks the user to input the PIN
        int userEntry = Convert.ToInt32(Console.ReadLine()); // Converts the users input into INT format
        if(userEntry == generatedOTP) // If statement to see if the user typed it correctly.
        {
            Console.WriteLine("VERIFIED.");
            Console.WriteLine("Account Holder: "+ fullName.ToUpper());
            Console.WriteLine("Account ID: " + accountID);
            Console.WriteLine("Current Balance: " + balance);
            Console.WriteLine("Balance in 10 years: " + balanceInTenYears);
        }
        else // Else statement if the user typed it incorrectly
        {
            Console.WriteLine("ACCESS DENIED: Unauthorized PIN entry.");
        }
        
        Console.WriteLine("Press any key to logout."); // Ending the code
        Console.ReadKey();
    }

}