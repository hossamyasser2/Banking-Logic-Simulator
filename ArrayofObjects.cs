using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Car[] garage = {new("Mustang", "red"), new("Corvette", "blue"), new("Lambo", "yellow")}; 
        garage[2] = Copy(garage[1]);
        foreach (Car car in garage)
        {
            Console.WriteLine(car.model + " " + car.color);
        }
        
    }

    public static Car Copy(Car car)
    {
        return new Car(car.model, car.color); 
    }
}
class Car
{
    public String model;
    public String color;

    public Car (String model, String color)
    {
        this.model = model;
        this.color = color;
    }
}