using System;

class Program
{
    static void Main(string[] args)
    {
        // array is a variable that can store multiple values with a fixed size.
        // foreach loop is a simpler way to itterate over an array. However it is less flexible.
        String[] cars = new string[3];
        // String[] cars = {"BMW","Corvette", "Sting Ray"};
        cars[0] = "Tesla";
        cars[1] = "Corvette";
        cars[2] = "Sting Ray";
        /* for (int i=0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        */
        foreach(String car in cars)
        {
            Console.WriteLine(car);
        }
    }
}