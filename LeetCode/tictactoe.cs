using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class TicTacToe
    {
        string[,] board;
        int size;
        string curValue;
        /** Initialize your data structure here. */
        public TicTacToe(int n)
        {
            board = new string[n, n];
            size = n;
        }

        /** Player {player} makes a move at ({row}, {col}).
            @param row The row of the board.
            @param col The column of the board.
            @param player The player, can be either 1 or 2.
            @return The current winning condition, can be either:
                    0: No one wins.
                    1: Player 1 wins.
                    2: Player 2 wins. */
        public int Move(int row, int col, int player)
        {
            if (player == 1)
            {

                curValue = "X";
            }
            else
            {
                curValue = "0";
            }
            board[row, col] = curValue;
            if (Validate(row, col, player))
                return 1;
            else
                return 0;

        }
        private bool Validate(int row, int col, int player)
        {
            var isComplete = true;
            var isRowComplete = true;
            var isColComplete = true;
            var isDiaComplete = true;
            var isrDiaComplete = true;
            for (int i = 0; i < size; i++)
            {
                if (curValue != board[row, i])
                {
                    isRowComplete = false;
                }
                if (curValue != board[i, col])
                {
                    isColComplete = false;
                }
                if (curValue != board[i, i])
                {
                    isDiaComplete = false;
                }
            }

            isComplete = isRowComplete || isColComplete || isDiaComplete;
            if (!isComplete)
            {
                for (int i = 0, j = size - 1; i < size; i++, j--)
                {
                    if (curValue != board[i, j])
                    {
                        isrDiaComplete = false;
                    }
                }
            }
            return isComplete || isrDiaComplete;
        }
    }

    /**
     * Your TicTacToe object will be instantiated and called as such:
     * TicTacToe obj = new TicTacToe(n);
     * int param_1 = obj.Move(row,col,player);
     */
}
