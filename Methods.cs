using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        string name = "name";
        int age = 20;
        string month = "month";

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