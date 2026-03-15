using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What day is it today?");
        String day = Console.ReadLine();

        switch (day)
        {
            case "Monday":
                Console.WriteLine("Its Monday!");
                break;
            case "Tuesday":
                Console.WriteLine("Its Tuesday!");
                break;
            case "Wednesday":
                Console.WriteLine("Its Wednesday!");
                break;        
            case "Thursday":
                Console.WriteLine("Its Thursday!");
                break;
            case "Friday":
                Console.WriteLine("Its Friday!");
                break;
            case "Saturday":
                Console.WriteLine("Its Saturday!");
                break;
            case "Sunday":
                Console.WriteLine("Its Sunday!");
                break;         
            default: 
                Console.WriteLine(day + " is not a day!");
                break;   
        }

    }
}