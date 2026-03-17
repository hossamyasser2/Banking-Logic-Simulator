using System; 

class Program
{
    static void Main(string[] args)
    {
        string name = "";
        while (name == "")
        {
        Console.WriteLine("Enter your name");
        name = Console.ReadLine();
        }

        Console.WriteLine("Hello " + name);
    }
}