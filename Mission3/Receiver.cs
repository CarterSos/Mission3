using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    class Receiver
    {
        void printBoard(string[] gameBoard)
        {
            int arrayIndex = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write("_" + gameBoard[arrayIndex] + "_");
                    arrayIndex++;
                    if (j != 2)
                    {
                        Console.Write("|");
                    }
                }
                Console.WriteLine("\n");
                if (i != 2)
                {
                    Console.Write("--------------------");
                }
            }
        }

        void chooseWinner(string[] gameBoard)
        {

        }
    }
}
