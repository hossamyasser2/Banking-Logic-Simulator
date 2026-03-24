using System;
class Program
{
    static void Main(string[] args)
    {
        Human human1 = new Human("Rick", 65);
        Human human2 = new Human("Morty", 16);

        human1.eat();
        human1.sleep();
        human2.eat();
        human2.sleep();
    }

}

class Human
{
    public String name;
    public int age;

    // This is a constructor. It allows you to instead of manually assigning the values human1 
    // and human2 have,you can insert them into the brackets and it will be sent to the constructor below to store them in name and age
    public Human(String name, int age)
    {
        this.name = name;
        this.age = age;
    }
    
    
    public void eat()
    {
        Console.WriteLine($"{name} is eating.");
    }
    public void sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }
}