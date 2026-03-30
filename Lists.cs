using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<String> food = ["Pizza", "Hamburger", "Hotdog", "Bread"];
        food.Add("Fries");
        food.Remove("Bread");
        food.Insert(0,"Sushi");
        food.Add("Fries");
        System.Console.WriteLine(food.Count);
        System.Console.WriteLine(food.IndexOf("Pizza"));
        System.Console.WriteLine(food.LastIndexOf("Fries"));
        System.Console.WriteLine(food.Contains("Pizza"));
        food.Sort();
        // food.Reverse();
        // food.Clear();
        String[] foodArray = food.ToArray();

        foreach(String item in foodArray)
        {
            System.Console.WriteLine(item);
        }
    }
}