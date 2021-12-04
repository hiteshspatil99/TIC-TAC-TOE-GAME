using System;

namespace TicTocToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game");
            TicTocToeGame game = new TicTocToeGame();
            game.gameBoard();
        }
    }
}
