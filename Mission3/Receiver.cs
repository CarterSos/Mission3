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

        void chooseWinner(string[] pos)
            
        {
            //Horizontal O
            int winFlag1 = 0;
            int winFlag2 = 0;
            if (pos[0] == "o" && pos[1] == "o" && pos[2] == "o")
            {
                winFlag1 = 1;
            }
            
            else if(pos[3] == "o" && pos[4]== "o" && pos[5] == "o")
            {
                winFlag1 = 1;
            }
            else if (pos[6] == "o" && pos[7] == "o" && pos[8] == "o")
            {
                winFlag1 = 1;
            }

            // Horizontal x
            else if (pos[0] == "x" && pos[1] == "x" && pos[2] == "x")
            {
                winFlag2 = 1;
            }

            else if (pos[3] == "x" && pos[4] == "x" && pos[5] == "x")
            {
                winFlag2 = 1;
            }
            else if (pos[6] == "x" && pos[7] == "x" && pos[8] == "x")
            {
                winFlag2 = 1;
            }


            //Vertical o
            else if (pos[0] == "o" && pos[3] == "o" && pos[6] == "o")
            {
                winFlag1 = 1;
            }

            else if (pos[1] == "o" && pos[4] == "o" && pos[7] == "o")
            {
                winFlag1 = 1;
            }
            else if (pos[2] == "o" && pos[5] == "o" && pos[8] == "o")
            {
                winFlag1 = 1;
            }

            //Vertical X

            else if (pos[0] == "x" && pos[3] == "x" && pos[6] == "x")
            {
                winFlag2 = 1;
            }

            else if (pos[1] == "x" && pos[4] == "x" && pos[7] == "x")
            {
                winFlag2 = 1;
            }
            else if (pos[2] == "x" && pos[5] == "x" && pos[8] == "x")
            {
                winFlag2 = 1;
            }

            //Cross O
            else if (pos[0] == "o" && pos[4] == "o" && pos[8] == "o")
            {
                winFlag1 = 1;
            }

            else if (pos[2] == "o" && pos[4] == "o" && pos[6] == "o")
            {
                winFlag1 = 1;
            }

            //Cross X
            else if (pos[0] == "x" && pos[4] == "x" && pos[8] == "x")
            {
                winFlag2 = 1;
            }

            else if (pos[2] == "x" && pos[4] == "x" && pos[6] == "x")
            {
                winFlag2 = 1;
            }

            else if (pos[0] != "1" && pos[1] != "2" && pos[2] != "3" && pos[3] != "4" && pos[4] != "5" && pos[5] != "6" && pos[6] != "7" && pos[7] != "8" && pos[8] != "9")
            {
                winFlag1 = -1;
                winFlag2 = -1;
            }

            if (winFlag1 == 1)
            {
                Console.WriteLine("\n\nPlayer 2 (o) wins!")
            }
            else if (winFlag2 == 1)
            {
                Console.WriteLine("\n\nPlayer 1 (x) wins!")
            }
        }
    }
}
