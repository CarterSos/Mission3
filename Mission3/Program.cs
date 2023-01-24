using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            string[] gameBoard = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" }; // array contains 0-9 and makes no use of index 0
            int playerCount = 1;
            bool keepPlaying = true;

            while (keepPlaying)
            {

                if (playerCount % 1 == 1) // alternates between player 1 and player 2 based on odd or even playerCount
                {
                    Console.WriteLine("Player 1's Turn: ");
                }

                else
                {
                    Console.WriteLine("Player 2's Turn: ");
                }

                // now get choice from user (number 1 through 9)
                int choice = Console.ReadLine();

                if (gameBoard[choice] == "X" || gameBoard[choice] == "O") // checks if spot is already taken
                {
                    Console.WriteLine("Sorry, this spot is already taken!");
                }

                else // else replace that spot with X or O
                {
                    if (playerCount % 1 == 1)
                    {
                        gameBoard[choice] = 'X';
                        printBoard(gameBoard);
                        playerCount++; // increments playerCount to go to the next player's turn
                    }

                    else
                    {
                        gameBoard[choice] = 'O';
                        printBoard(gameBoard);
                        playerCount++; // increments playerCount to go to the next player's turn
                    }
                }

                chooseWinner(gameBoard);

                if (chooseWinner(gameBoard) == "(Player 1 wins!)" || chooseWinner(gameBoard) == "Player 2 wins!")
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