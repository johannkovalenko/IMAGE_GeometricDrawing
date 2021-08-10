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

        public void Run(Point startPoint, Color color)
        {
            var points = new List<Point>();

            points.Add(startPoint);

            int startIndex = 0;
            Color startColor = bmp.GetPixel(startPoint);

            int totalPixels = bmp.TotalPixels();

            while (true)
            {
                if (points.Count > totalPixels)
                {
                    Console.WriteLine("Emergency Exit");
                    break;
                }

                int iterations = points.Count;
                for (int it = startIndex; it < iterations; it++)
                {
                    Point point = points[it];

                    foreach(int[] direction in directions)
                    {
                        var neighbor = new Point(point.X + direction[0], point.Y + direction[1]);

                        if (!bmp.WithinBMP(neighbor))
                            continue;

                        Color neighborColor = bmp.GetPixel(neighbor);

                        if (neighborColor == startColor)
                        {
                            bmp.SetPixel(neighbor, color);
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