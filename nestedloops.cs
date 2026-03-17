using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.Write("How many rows would you like?: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("How many columns would you like?: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.Write("What symbol would you like to use?: ");
        string symbol = Console.ReadLine();

        for (int i= 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(symbol);
            }
        Console.WriteLine();
        }


    }
}