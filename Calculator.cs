using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine(" This is a Calculator program");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("What calculation would you like to do?");
        string operation;
        double firstNumber = 0;
        double secondNumber = 0;
        double answer = 0;
        double remainder = 0;

        do
        {
            Console.WriteLine("\t+ | Addition");
            Console.WriteLine("\t- | Subtraction");
            Console.WriteLine("\t/ | Division");
            Console.WriteLine("\t* | Multiplication");
            Console.WriteLine("\t% | Power of");
            Console.WriteLine("\t# | Square root");
            operation = Console.ReadLine().ToLower();
            Console.WriteLine("Enter your first Number: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            if (operation != "#")
            {
                Console.WriteLine("Enter your second Number: ");
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }
            switch (operation)
            {
                case "+":
                    Console.WriteLine("You have chosen addition.");
                    answer = firstNumber + secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} + {secondNumber} = {answer}.");
                    break;
                case "-":
                    Console.WriteLine("You have chosen subtraction.");
                    answer = firstNumber - secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} - {secondNumber} = {answer}.");
                    break;
                case "/":
                    Console.WriteLine("You have chosen division."); ;
                    answer = firstNumber / secondNumber;
                    remainder = firstNumber % secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} / {secondNumber} = {answer}.");
                    Console.WriteLine($"With a remainder of {remainder}");
                    break;
                case "*":
                    Console.WriteLine("You have chosen multiplication.");
                    answer = firstNumber * secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} * {secondNumber} = {answer}.");
                    break;
                case "%":
                    Console.WriteLine("You have chosen power of.");
                    answer = Math.Pow(firstNumber, secondNumber);
                    Console.WriteLine($"Answer: {firstNumber} to the power of {secondNumber} = {answer}.");
                    break;
                case "#":
                    Console.WriteLine("You have chosen square root.");
                    answer = Math.Sqrt(firstNumber);
                    Console.WriteLine($"The square root of {firstNumber} is {answer}.");
                    break;
                default:
                    Console.WriteLine("This is not a valid operation.");
                    break;
            }
            Console.WriteLine("Would you like to use the calculator again? (Y = Yes, Anything else = No)");
        } while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("Goodbye.");
    }
}