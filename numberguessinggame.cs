using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int number = random.Next(1, 100);
        int attempts = 1;
        int guess;
        string response;

        while (playAgain)
        {
            guess = 0;
            attempts = 0;
            response = "";
            number = random.Next(1, 101);
            while (guess != number)
            {
                Console.WriteLine("Guess a number between 1 and 100!");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);
                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low");
                }
                attempts++;
            }
            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!");
            Console.WriteLine(attempts + " guesses!");
            Console.WriteLine("Would you like to play again? (Y/N): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response != "Y")
            {
                playAgain = false;
            }
        }
    }

}
