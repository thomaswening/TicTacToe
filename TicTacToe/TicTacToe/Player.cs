using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        static int numberOfPlayers = 0;

        private int playerNumber;
        private List<int> moves = new List<int>();

        public int PlayerNumber { get { return playerNumber; } }
        public List<int> Moves { get { return moves; } }
        public int LastMove { get { return moves[moves.Count - 1]; } }

        public Player()
        {
            numberOfPlayers++;
            playerNumber = numberOfPlayers;
        }

        public override string ToString()
        {
            string line1 = $"playerNumber : {playerNumber}\n";
            string line2 = "moves : " + MovesToString();

            return line1 + line2;
        }

        public void MakeMove(int fieldNumber)
        {
            moves.Add(fieldNumber);
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
