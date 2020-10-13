using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame ticTacToeGame = new TicTacToeGame();
            char[] board = ticTacToeGame.createBoardTicTacToe();
            char userOption = ticTacToeGame.chooseLetterOption();
            char computerOption = ticTacToeGame.getcomputerOption();
            ticTacToeGame.showBoard(board);
        }
    }
}
