using System;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;

namespace JK.Tools.Drawing
{
    public class MagicFill
    {
        private BMP bmp;

        private int[][] directions = {
            new int[] {0, 1}, 
            new int[] {0, -1},
            new int[] {1, 0}, 
            new int[] {-1, 0}
        };


        public void UpdateBMP(BMP bmp)
        {
            this.bmp = bmp;
        }

        public void Run(int startX, int startY, Color color)
        {
            var points = new List<Point>();

            points.Add(new Point(startX, startY));

            int startIndex = 0;
            Color startColor = bmp.GetPixel(startX, startY);

            while (true)
            {
                int iterations = points.Count;
                for (int it = startIndex; it < iterations; it++)
                {
                    Point point = points[it];

                    foreach(int[] direction in directions)
                    {
                        var neighbor = new Point(point.X + direction[0], point.Y + direction[1]);

                        Color neighborColor = bmp.GetPixel(neighbor.X, neighbor.Y);

                        if (neighborColor != Color.Black && neighborColor == startColor)
                        {
                            bmp.SetPixel(neighbor.X, neighbor.Y, color);
                            points.Add(neighbor);
                        }
                    }
                }
                if (points.Count == iterations)
                    break;

                startIndex = iterations - 1;
            }
        }
    }
}