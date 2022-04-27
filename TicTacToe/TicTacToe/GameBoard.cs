using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Represents the 3x3 game board for TicTacToe
    /// </summary>
    class GameBoard
    {
        private int[] fields;

        public GameBoard() => fields = new int[9];

        /// <summary>
        /// Prints the game board to the console
        /// </summary>
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

        /// <summary>
        /// Logs the players' moves into the game board.
        /// </summary>
        /// <param name="playerNumber">Number of the player whose moves are to be logged.</param>
        /// <param name="fieldNumber">Number of the game board's field where the player's move is to be logged.</param>
        public void LogMove(int playerNumber, int fieldNumber)
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

        public int Field(int fieldNumber) => fields[fieldNumber - 1];
    }
}
