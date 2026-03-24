using System;
class Program
{
    static void Main(string[] args)
    {
        Human human1 = new Human();
        Human human2 = new Human();


        human1.name = "Rick";
        human1.age = 65;

        human2.name = "Morty";
        human2.age = 16;

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
    
    public void eat()
    {
        Console.WriteLine($"{name} is eating.");
    }
    public void sleep()
    {
        Console.WriteLine($"{name} is sleeping.");
    }
}