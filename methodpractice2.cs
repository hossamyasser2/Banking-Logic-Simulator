using System;
using System.Formats.Asn1;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        string result = "";
        while (result != "Your password is strong.")
        {
        Console.WriteLine("Enter a password: ");
        string password = Console.ReadLine();
        result = PasswordStrength(password);
        Console.WriteLine(result);
        }
    }
    static string PasswordStrength(string a)
    {
        if (a.Length <= 8 && !a.Contains('!'))
        {
            return "This password is too weak. Please use a minimum of 8 characters and contains an exclamation mark(!)";
        }
        else
        {
            return "Your password is strong.";
        }
    }
}