using System;
using System.Collections.Generic;

namespace TicTacToe
{
    class WinningLines
    {
        static private int numberOfInstances = 0;

        // Rows
        static readonly int[] winningRow1 = { 1, 2, 3 };
        static readonly int[] winningRow2 = { 4, 5, 6 };
        static readonly int[] winningRow3 = { 7, 8, 9 };

        // Columns
        static readonly int[] winningCol1 = { 1, 4, 7 };
        static readonly int[] winningCol2 = { 2, 5, 8 };
        static readonly int[] winningCol3 = { 3, 6, 9 };

        // Diagonals
        static readonly int[] winningDia1 = { 1, 5, 9 };
        static readonly int[] winningDia2 = { 3, 5, 7 };

        // List of the above
        private List<int[]> winningLines = new List<int[]>();

        public WinningLines()
        {
            if (numberOfInstances == 0)
            {
                winningLines.Add(winningRow1);
                winningLines.Add(winningRow2);
                winningLines.Add(winningRow3);

                winningLines.Add(winningCol1);
                winningLines.Add(winningCol2);
                winningLines.Add(winningCol3);

                winningLines.Add(winningDia1);
                winningLines.Add(winningDia2);

                numberOfInstances++;
            }
        }

        /// <summary>
        /// Takes one winning line at a time, goes through its fields and checks if the players' moves contain these fields.
        /// If there is a match, hit is increased by one. If there are three hits after the iteration through one line,
        /// that means that the player has managed to construct a winning line. In that case, the player's property HasWon is set to true
        /// and the method returns true. Otherwise, it returns false;
        /// </summary>
        /// <param name="player">Instance of the player whose moves are to be checked for a win.</param>
        /// <returns>If the player has won, then the method returns true. Otherwise, it returns false.</returns>
        public bool CheckForWinner(Player player)
        {
            foreach (int[] line in winningLines)
            {
                int hits = 0;
                foreach (int field in line)
                {
                    if (player.Moves.Contains(field)) hits++;
                }

                if (hits == 3)
                {
                    Console.WriteLine($"Congratulations, player {player.PlayerNumber}! You have WON!");
                    player.HasWon = true;
                    return true;
                }
            }

            return false;
        }
    }
}
