using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bicycle bicycle = new Bicycle();
        Boat boat = new Boat();

        Vehicle[] vehicles = {car,bicycle,boat};
        
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.Go();
        }

    }
}
class Vehicle
{
    public virtual void Go()
    {
        System.Console.WriteLine("The vehicle is moving!");
    }
}
class Car : Vehicle
{
    public override void Go()
    {
        System.Console.WriteLine("The Car is moving!");
    }
}
class Bicycle : Vehicle
{
    public override void Go()
    {
        System.Console.WriteLine("The Bicycle is moving!");
    }
}
class Boat : Vehicle
{
    public override void Go()
    {
        System.Console.WriteLine("The Boat is moving!");
    }
}