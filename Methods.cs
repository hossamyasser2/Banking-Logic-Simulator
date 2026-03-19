using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string name = "Hossam";
        int age = 5;
        string month = "April";

        singHappyBirthday(name,age,month);
        singHappyBirthday(name,age,month);
        singHappyBirthday(name,age,month);
    }
     static void singHappyBirthday(string brosName, int birthdayageboy, string monthguy)
        {
            Console.WriteLine($"HAPPY BIRTHDAY!! {birthdayageboy} {brosName} {monthguy}");
            Console.WriteLine("HAPPY BIRTHDAY!!");
            Console.WriteLine("HAPPY BIRTHDAY!!");
            Console.WriteLine("HAPPY BIRTHDAY!!");
        }
}