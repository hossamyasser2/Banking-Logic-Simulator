using System;
class Program
{
    static void Main(string[] args)
    {
        Messages.Hello(" Jake ");
    }
}
static class Messages
{

    public static void Hello(string name)
    {
        Console.WriteLine($"Hello {name} Welcome to the program.");
    }
}