using System;
class Program
{
    static void Main(string[] args)
    {
        Pizza pizza1 = new Pizza("Stuffed Crust", "Red Sauce", "Mozerella");
    }
}
class Pizza
{
    String bread;
    String sauce;
    String cheese;
    String toppings;

    public Pizza(String bread, String sauce, String cheese, String toppings)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        this.toppings = toppings;
        Console.WriteLine($"Your pizza has {bread} , {sauce} , {cheese} , {toppings}.");
    }
    public Pizza(String bread, String sauce, String cheese)
    {
        this.bread = bread;
        this.sauce = sauce;
        this.cheese = cheese;
        Console.WriteLine($"Your pizza has {bread} , {sauce} , {cheese}.");
    }
    public Pizza(String bread, String sauce)
    {
        this.bread = bread;
        this.sauce = sauce;
        Console.WriteLine($"Your pizza has {bread} , {sauce}.");
    }
    public Pizza(String bread)
    {
        this.bread = bread;
        Console.WriteLine($"Your pizza has {bread}.");
    }
}