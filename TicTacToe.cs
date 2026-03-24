using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] Board = {
            {" ", " ", " "},
            {" ", " ", " "},
            {" ", " ", " "}
        };

        bool gameOver = false;
        string currentPlayer = "X";

        while (!gameOver)
        {
            // This calls the method to draw the board at the start of every turn
            DrawBoard(Board);

            try
            {
                Console.WriteLine($"\nPlayer {currentPlayer}, enter a row (0-2): ");
                int row = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Player {currentPlayer}, enter a column (0-2): ");
                int column = Convert.ToInt32(Console.ReadLine());

                // This checks if there is already something in that slot.
                if (Board[row, column] != " ")
                {
                    Console.WriteLine("That spot is taken! Press Enter to try again.");
                    Console.ReadLine();
                    continue; 
                }

                Board[row, column] = currentPlayer;

                // This checks for the win
                if (CheckForWin(Board, currentPlayer))
                {
                    DrawBoard(Board);
                    Console.WriteLine($"\n🎉 PLAYER {currentPlayer} WINS! 🎉");
                    gameOver = true;
                }
                else
                {
                    // If no one won, switch the player
                    currentPlayer = (currentPlayer == "X") ? "O" : "X";
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Error: That's off the board! Use 0, 1, or 2. Press Enter.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number. Press Enter.");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: " + e.Message);
                Console.ReadLine();
            }
        }
        Console.WriteLine("Game Over. Thanks for playing!");
    }

    // METHOD 1: Handles the visuals
    static void DrawBoard(string[,] board)
    {
        Console.Clear(); // Cleans the screen so the board stays in one place
        Console.WriteLine("   0  1  2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " "); // Row labels
            for (int j = 0; j < 3; j++)
            {
                Console.Write("[" + board[i, j] + "]");
            }
            Console.WriteLine();
        }
    }

    // METHOD 2: Handles the math/logic of winning
    static bool CheckForWin(string[,] b, string p)
    {
        // Check Rows and Columns
        for (int i = 0; i < 3; i++)
        {
            if (b[i, 0] == p && b[i, 1] == p && b[i, 2] == p) return true; // Row win
            if (b[0, i] == p && b[1, i] == p && b[2, i] == p) return true; // Col win
        }

        // Check Diagonals
        if (b[0, 0] == p && b[1, 1] == p && b[2, 2] == p) return true;
        if (b[0, 2] == p && b[1, 1] == p && b[2, 0] == p) return true;

        return false;
    }
}