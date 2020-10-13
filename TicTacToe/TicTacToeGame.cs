﻿using System;
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
            if (place >= 1 && place <= 9 && board[place] == ' ')
            {
                return place;
            }
            else
                Console.WriteLine("Invalid input");
                return userDesiredMove(board);
        }
        public void MakingDesiredMove(char[] board, int move, char letter)
        {
            if (board[move] == ' ')
            {
                board[move] = letter;
            }
        }
        public string whoStartFirst()
        {
            int HEAD = 0;
            int TAIL = 1;
            string[] str = new string[2] { "USER", "COMPUTER" };
            Random random = new Random();
            int value = random.Next(0, 2);
            if (value == HEAD)
            {
                return str[0];
            }
            else
                return str[1];
        }
    }
}
