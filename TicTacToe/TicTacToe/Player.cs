using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    /// <summary>
    /// Represents a player in the game of TicTacToe.
    /// </summary>
    class Player
    {
        static int numberOfPlayers = 0;

        private int playerNumber;
        private List<int> moves = new List<int>();

        public int PlayerNumber { get { return playerNumber; } }
        public List<int> Moves { get { return moves; } }
        public int LastMove { get { return moves[moves.Count - 1]; } }
        public bool HasWon { get; set; }

        public Player()
        {
            numberOfPlayers++;
            playerNumber = numberOfPlayers;
            HasWon = false;
        }

        public override string ToString()
        {
            string line1 = $"playerNumber : {playerNumber}\n";
            string line2 = "moves : " + MovesToString();

            return line1 + line2;
        }

        public void MakeMove(GameBoard gameBoard)
        {
            bool fieldIsFree;

            Console.Write($"Make a move, player {playerNumber} >> ");
            int fieldNumber = Convert.ToInt32(Console.ReadLine());

            do
            {
                fieldIsFree = gameBoard.Field(fieldNumber) == 0;

                if (fieldIsFree)
                {
                    moves.Add(fieldNumber);
                    gameBoard.LogMove(playerNumber, LastMove);
                    gameBoard.Print();
                }
                else
                {
                    Console.Write("Please pick a free field >> ");
                    fieldNumber = Convert.ToInt32(Console.ReadLine());
                }
            }
            while (!fieldIsFree);
        }

        private string MovesToString()
        {
            StringBuilder sbMoves = new StringBuilder();
            foreach (int move in moves)
            {
                sbMoves.Append($"{move}, ");
            }
            sbMoves.Remove(sbMoves.Length - 2, 2);

            return sbMoves.ToString() + "\n";
        }

    }
}
