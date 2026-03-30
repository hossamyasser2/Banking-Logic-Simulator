using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
     Rabbit rabbit = new Rabbit();
     Hawk hawk = new Hawk();
     Fish fish = new Fish();
     fish.Flee();
     rabbit.Flee();
     hawk.Hunt();
     fish.Hunt();
    }
}
interface IPrey
{
    void Flee();
}
interface IPredator
{
    void Hunt();
}
class Rabbit : IPrey
{
    public void Flee()
    {
        System.Console.WriteLine("The rabbit runs away!");
    }
}
class Hawk : IPredator
{
    public void Hunt()
    {
        System.Console.WriteLine("The hawk is hunting!");
    }
}
class Fish : IPrey, IPredator
{
    public void Flee()
    {
        System.Console.WriteLine("The fish swims away!");
    }
    public void Hunt()
    {
        System.Console.WriteLine("The fish is hunting!");
    }
}