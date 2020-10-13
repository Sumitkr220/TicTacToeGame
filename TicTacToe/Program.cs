using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            char[] board = ticTacToeGame.createBoardTicTacToe();
            char option = ticTacToeGame.chooseLetterOption();
            Console.WriteLine(option);
        }
    }
}
