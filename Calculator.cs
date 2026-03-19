using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine(" This is a Calculator program");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("What calculation would you like to do?");
        bool isTrue = true;
        string operation;
        double firstNumber = 0;
        double secondNumber = 0;
        double answer = 0;
        double remainder = 0;

        while (isTrue)
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
            if(operation != "#")
            {
            Console.WriteLine("Enter your second Number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            }
            switch (operation)
            {
                case "+":
                    Console.WriteLine("You have chosen addition.");
                    answer = firstNumber + secondNumber;
                    Console.WriteLine($"The answer is {answer}.");
                    break;
                case "-":
                    Console.WriteLine("You have chosen subtraction.");
                    answer = firstNumber - secondNumber;
                    Console.WriteLine($"The answer is {answer}.");
                    break;
                case "/":
                    Console.WriteLine("You have chosen division.");;
                    answer = firstNumber / secondNumber;
                    remainder = firstNumber % secondNumber;
                    Console.WriteLine($"The answer is {answer}.");
                    Console.WriteLine($"With a remainder of {remainder}");
                    break;
                case "*":
                    Console.WriteLine("You have chosen multiplication.");
                    answer = firstNumber * secondNumber;
                    Console.WriteLine($"The answer is {answer}.");
                    break;
                case "%":
                    Console.WriteLine("You have chosen power of.");
                    answer = Math.Pow(firstNumber, secondNumber);
                    Console.WriteLine($"The answer is {answer}.");
                    break;
                case "#":
                    Console.WriteLine("You have chosen square root.");
                    answer = Math.Sqrt(firstNumber);
                    Console.WriteLine($"The answer is {answer}.");
                    break;
                default:
                    Console.WriteLine("This is not a valid operation.");
                    break;
            }
            string repeat;
            bool repeats = true;
            while (repeats)
            {
                Console.WriteLine("Would you like to use the calculator again? Y/N");
                repeat = Console.ReadLine().ToUpper();
                switch (repeat)
                {
                    case "Y":
                        isTrue = true;
                        repeats = false;
                        break;
                    case "N":
                        isTrue = false;
                        repeats = false;
                        break;
                    default:
                        Console.WriteLine("Please pick either Y/N.");
                        break;
                }
            }
        }


    }
}