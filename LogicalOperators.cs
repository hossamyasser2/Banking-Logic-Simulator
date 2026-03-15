using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Whats the temprature outside?");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (temp >= 10 && temp <= 25)
        {
            Console.WriteLine("Its Warm Outside!");
        }
        else if (temp <= -50 || temp >=50)
        {
            Console.WriteLine("Dont go outside");
        }
        else if (temp > 25 && temp < 50)
        {
            Console.WriteLine("Nice day outside!");
        }

        Console.ReadKey();


    }
}