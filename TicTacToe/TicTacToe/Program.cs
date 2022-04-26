using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameBoard gameBoard = new GameBoard();
            Player player1 = new Player();
            Player player2 = new Player();

            player1.MakeMove(1);
            player2.MakeMove(3);

            Console.WriteLine(player1);
            Console.WriteLine(player2);

            gameBoard.LogMoves(player1.PlayerNumber, player1.LastMove);
            gameBoard.LogMoves(player2.PlayerNumber, player2.LastMove);
            gameBoard.Print();
        }
    }
}
