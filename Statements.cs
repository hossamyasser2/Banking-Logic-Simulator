using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Secure Bank Terminal");
        Console.WriteLine("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());
        if (userAge > 100)
        {
            Console.WriteLine("You are probably dead hahaha!");
        }
        else if (userAge <= 0)
        {
            Console.WriteLine("You are not born yet hahaha!");
        }
        else if (userAge >=18)
        {
            Console.WriteLine("You meet the requirements for a credit card.");
            Console.WriteLine("You have succesfully signed up for a credit card.");
        }
        else
        {
            Console.WriteLine("You are too young for a credit card.");
            Console.WriteLine("User must be above 18 years old.");
        }



    }



}