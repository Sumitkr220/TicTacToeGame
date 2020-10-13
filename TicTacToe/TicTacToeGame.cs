using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        private char computerOption;
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
            userOption = char.ToUpper(userOption);
            if (userOption != 'X' || userOption != 'O')
            {
                while (userOption != 'X' && userOption != 'O')
                {
                    Console.WriteLine("Invalid input Choose X or O");
                    Console.WriteLine("Choose X or O");
                    userOption = Console.ReadLine()[0];
                    userOption = char.ToUpper(userOption);
                }
            }
            if (userOption == 'X')
            {
                computerOption = 'O';
            }
            else
            {
                computerOption = 'X';
            }
            return userOption;
        }
        public char getcomputerOption()
        {
            return computerOption;
        }
        public void showBoard(char[] board)
        {
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(board[k++] + " | " + board[k++] + " | " + board[k++]);
                if (i <= 1)
                {
                    Console.WriteLine("-----------");
                }
            }
        }
        public int userDesiredMove(char[] board)
        {
            Console.WriteLine("Choose your move b/w 1 to 9");
            int place = Convert.ToInt32(Console.ReadLine());
            if ((place >= 1 && place <= 9) && board[place] == ' ')
            {
                return place;
            }
            else
                return -1;
        }
    }
}
