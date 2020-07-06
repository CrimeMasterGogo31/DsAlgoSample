using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.Design
{
    public class TicTacToe
    {
        int[] rows;
        int[] cols;
        int dia;
        int antidia;
        int n;
        /** Initialize your data structure here. */
        public TicTacToe(int n)
        {
            this.n = n;
            rows = new int[n];
            cols = new int[n];
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
            var cur = 1;
            if (player == 2)
                cur = -1;

            rows[row] += cur;
            cols[col] += col;

            if (row == col)
                dia += cur;

            if (row == n - col - 1)
                antidia += cur;

            if (Math.Abs(rows[row]) == n || Math.Abs(cols[col]) == n || Math.Abs(dia) == n || Math.Abs(antidia) == n)
                return player;
            else
                return 0;

        }

    }
}
