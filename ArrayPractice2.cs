using System;

class Program
{
    static void Main(string[] args)
    {
        Double[] transactions = new double[5];
        double total = 0;
        for(int i=0; i < transactions.Length; i++)
        {
            Console.WriteLine($"Please enter a transaction amount for Transaction #{i + 1}: ");
            transactions[i] = Convert.ToDouble(Console.ReadLine());
        }
        foreach (double trans in transactions )
        {
            Console.WriteLine($"Transaction # {trans}");
            total += trans;
        }
        Console.WriteLine($"Total balance is: {total}");
    }
}