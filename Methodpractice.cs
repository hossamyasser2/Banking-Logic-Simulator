using System;
using System.IO.Compression;
using System.IO.Pipelines;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        double x;
        double y;
        double z;
        double answer;
        Console.WriteLine("Enter the first number: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        z = Convert.ToDouble(Console.ReadLine());
        answer = Division(x, y, z);
        Console.WriteLine($"The answer is {answer}.");
    }
    static double Division(double x, double y)                  // method overloading share the same name but have different paramaters.
    {                                                           // name + parameters = unique signature.
        return x/y;                                             // methods must have a unique signature.
    }
    static double Division(double x, double y, double z)
    {
        return x/y/z;
    }
}