using System;
using System.Collections.Generic;

namespace TicTacToe
{
    internal class Program
    {
        static void Main()
        {
            int gameIteration = 1;
            bool gameIsOver = false;

            GameBoard gameBoard = new GameBoard();
            WinningLines winningLines = new WinningLines();
            Player player1 = new Player();
            Player player2 = new Player();

            while (gameIteration <= 9 && !gameIsOver)
            {
                Console.Clear();
                gameBoard.Print();

                if (gameIteration % 2 != 0)
                {
                    player1.MakeMove(gameBoard);
                    gameIsOver = winningLines.CheckForWinner(player1);
                }
                else
                {
                    player2.MakeMove(gameBoard);
                    gameIsOver = winningLines.CheckForWinner(player2);
                }

                gameIteration++;
            }

            Console.Write("Play another round? (y/n) >> ");
            char response = Convert.ToChar(Console.ReadLine());
            switch (response)
            {
                case 'y':
                    break;
                case 'n':
                    Console.WriteLine("Well, goodbye then! :)");
                    gameIsOver = true;
                    break;
            }
        }
    }
}
