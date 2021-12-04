using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocToeGame
{
    public class TicTocToeGame
    {
        public const char X = 'X';
        public const char O = 'O';
        public void gameBoard()
        {
            char[] board = new char[10];

            {
                for (int i = 0; i < 10; i++)
                {
                    board[i] = ' ';
                }
            }
        }
            public void playerInput()
            {
                Console.WriteLine("Enter you Selectfrom X or O :");
                char playerChoice = Convert.ToChar(Console.ReadLine());
                if (playerChoice == 'X')
                {
                    Console.WriteLine("Player select " + playerChoice);
                    Console.WriteLine("Computer select " + O);
                }
                else if (playerChoice == 'O')
                {
                    Console.WriteLine("Player Select " + playerChoice);
                    Console.WriteLine(" Computer Select " + X);
                }
                else
                {
                    Console.WriteLine("Invalid input  ");
                }
            }
    }
}
    
