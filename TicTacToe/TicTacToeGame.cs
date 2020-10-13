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
            int MAX_SIZE = board.Length;
            int i = 0;
            while(MAX_SIZE-->0)
            {
                board[i] = ' ';
                i++;
            }
            return board;
        }
        public char chooseLetterOption()
        {
            Console.WriteLine("Choose X or O");
            char userOption = Console.ReadLine()[0];
            if (userOption != 'X' || userOption != 'O')
            {
                while (userOption != 'X' && userOption != 'O')
                {
                    Console.WriteLine("Invalid input Choose X or O");
                    Console.WriteLine("Choose X or O");
                    userOption = Console.ReadLine()[0];
                }
            }
            return userOption;
        }
    }
}
