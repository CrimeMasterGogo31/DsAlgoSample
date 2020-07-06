using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole
{
    class TestAmz
    {
        private int _numRows;
        private int _numColumns;
        private int[,] _lot;
        public int removeObstacle(int numRows, int numColumns, int[,] lot)
        {
            _numRows = numRows;
            _numColumns = numColumns;
            _lot = lot;
            var moves = new List<List<int>>(){
                new List<int>() { -1,0},
                new List<int>() { 0,1},
                new List<int>() { 1,0},
                new List<int>() { 0,-1},
            };
            var start = new index(0,0);
            var traversedIndex = new List<index>();
            traversedIndex.Add(start);


            return 1;
        }

        //SearchDFS() {

        //}

        class index {
            public index(int X,int Y)
            {
                x = X;
                y = Y;
            }
            public int x { get; set; }
            public int y { get; set; }
        }

        bool ValidateIndex(index index) {
            var valid=false;
            if (index.x >= _numRows && index.x < 0)
            {
                valid = false;
            }
            else if (index.y >= _numColumns && index.y < 0)
            {
                valid = false;

            }
            else
            {
                var val = _lot[index.x, index.y];
                if (val == 0)
                {
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            return valid;
        }
    }
}
