using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public char[] createBoardTicTacToe()
        {
            char[] board = new char[10];
            int MAX_SIZE = 10;
            int i = 0;
            while(MAX_SIZE-->0)
            {
                board[i] = ' ';
                i++;
            }
            return board;
        }
    }
}
