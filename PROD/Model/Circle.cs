using System.Collections.Generic;
using System.Drawing;
using System;
using JKDraw = JK.Tools.Drawing;

namespace Model
{
    public class Circle : IGeo
    {
        private JKDraw.BMP bmp;

        private int[][] directions = {
            new int[] {0, 0},
            new int[] {0, 1}, 
            new int[] {0, -1},
            new int[] {1, 0}, 
            new int[] {-1, 0}
        };

        public Circle(JKDraw.BMP bmp)
        {
            this.bmp = bmp;
        }

        public void Prepare(int startX, int startY, Color color, int length)
        {
            for (double i=0;i<365;i++)
            {
                double dX = length * Math.Sin(i / 180 * Math.PI);
                double dY = length * Math.Cos(i / 180 * Math.PI);

                int x = startX + (int) (dX + 0.5);
                int y = startY - (int) (dY + 0.5);
                
                foreach (int[] direction in directions)
                    bmp.SetPixel(x + direction[0], y + direction[1], color);
            }
        }
    }
}