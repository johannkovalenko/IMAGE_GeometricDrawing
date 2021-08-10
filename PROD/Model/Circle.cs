using System.Collections.Generic;
using System.Drawing;
using System;
using JKDraw = JK.Tools.Drawing;

namespace Model
{
    public class Circle : IGeo
    {
        public override void Prepare(JKDraw.BMP bmp, Point startPoint, Color color, int length, int angle)
        {
            for (double i=0;i<360;i+=0.5)
            {
                double dX = length * Math.Sin(i / 180 * Math.PI);
                double dY = length * Math.Cos(i / 180 * Math.PI);

                int x = startPoint.X + (int) (dX + 0.5);
                int y = startPoint.Y - (int) (dY + 0.5);
                
                foreach (int[] direction in base.directions)
                {
                    var point = new Point(x + direction[0], y + direction[1]);
                    bmp.SetPixel(point, color);
                }
            }
        }
    }
}