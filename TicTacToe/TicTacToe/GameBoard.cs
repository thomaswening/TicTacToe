using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class GameBoard
    {
        private int[] fields;

        public GameBoard()
        {
            fields = new int[9];
        }

        public void Print()
        {
            Console.Write("\n\n");
            for (int i = 0; i < fields.Length; i++)
            {
                switch (fields[i])
                {
                    case 0:
                        Console.Write($" {i + 1} ");
                        break;

                    case 1:
                        Console.Write(" X ");
                        break;

                    case 2:
                        Console.Write(" O ");
                        break;
                }

                // print a blank line after 3 fields
                if ((i + 1) % 3 == 0) Console.Write("\n\n");
            }
        }

        public void LogMoves(int playerNumber, int fieldNumber)
        {
            switch (playerNumber)
            {
                case 1:
                    fields[fieldNumber - 1] = 1;
                    break;

                case 2:
                    fields[fieldNumber - 1] = 2;
                    break;
            }
        }
    }
}
