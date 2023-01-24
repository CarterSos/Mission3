using System;

namespace Mission3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Receiver re = new Receiver(); // declare instance of Receiver class
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; // array contains 1-9
            int playerCount = 1;
            bool keepPlaying = true;
            
            while (keepPlaying)
            {
                re.printBoard(gameBoard);
                if (playerCount % 2 == 1) // alternates between player 1 and player 2 based on odd or even playerCount
                {
                    Console.WriteLine("Player 1's Turn: ");
                }

                else
                {
                    Console.WriteLine("Player 2's Turn: ");
                }

                // now get choice from user (number 1 through 9)
                int choice = Convert.ToInt32(Console.ReadLine());

                if (gameBoard[choice - 1] == "x" || gameBoard[choice - 1] == "o") // checks if spot is already taken
                {
                    Console.WriteLine("Sorry, this spot is already taken!");
                }

                else // else replace that spot with X or O
                {
                    if (playerCount % 2 == 1)
                    {
                        gameBoard[choice - 1] = "x";

                        playerCount++; // increments playerCount to go to the next player's turn
                    }

                    else
                    {
                        gameBoard[choice - 1] = "o";
                        playerCount++; // increments playerCount to go to the next player's turn
                    }
                }

                re.chooseWinner(gameBoard);

                if (re.winFlag1 != 0 || re.winFlag2 != 0)
                {
                    keepPlaying = false;
                }

                else
                {
                    keepPlaying = true;
                }

            } // end of while loop
        }
    }
}