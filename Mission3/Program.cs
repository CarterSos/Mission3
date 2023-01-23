using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            string[] gameBoard = { " ", " ", " ", " ", " ", " ", " ", " ", " "};

            Console.WriteLine("Player 1: ");
            int choice = Console.ReadLine();
            gameBoard[choice] = 'x'
            
            printBoard(gameBoard);

            Console.WriteLine("Player 2: ");
            int choice = Console.ReadLine();
            gameBoard[choice] = 'o'

            printBoard(gameBoard);
        }
    }
}
