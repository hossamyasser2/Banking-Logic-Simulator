using System;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "Hossam";
        string lastName = "Yasser";
        int age = 21;
        Console.WriteLine($"Hello {firstName,2} {lastName,2}, You are {age,2} years old.");
    }
}