using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsole.LeetCode
{
    public class FloodFillc
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            //image[sr][sc] = newColor;
            floodfill(image, sr, sc, newColor, image[sr][sc]);
            return image;
        }

        void floodfill(int[][] image, int sr, int sc, int newColor, int startColor)
        {
            var r = image.Length;
            var c = image[0].Length;
            if (sr < 0 || sr >= r || sc < 0 || sc >= c)
                return;

            if (image[sr][sc] == newColor)
                return;
            if (image[sr][sc] != startColor)
                return;

            image[sr][sc] = newColor;

            floodfill(image, sr + 1, sc, newColor, startColor);
            floodfill(image, sr - 1, sc, newColor, startColor);
            floodfill(image, sr, sc + 1, newColor, startColor);
            floodfill(image, sr, sc - 1, newColor, startColor);

        }
    }
}
