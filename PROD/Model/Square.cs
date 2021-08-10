using System.Collections.Generic;
using System.Drawing;
using System;
using JKDraw = JK.Tools.Drawing;

namespace Model
{
    public class Square : IGeo
    {
        public override void Prepare(JKDraw.BMP bmp, Point startPoint, Color color, int length, int angleInt)
        {
            double angle = (double)angleInt;
            double startX = (double) startPoint.X - length/2;
            double startY = (double) startPoint.Y + length/2;

            for (int i=0; i<4; i++)
            {
                if (angle >= 360)
                    angle = angle - 360;

                double dX = 0.0;
                double dY = 0.0;

                for (double j=1;j<=length;j++)
                {
                    dX = j * Math.Sin(angle / 180 * Math.PI);
                    dY = j * Math.Cos(angle / 180 * Math.PI);
                    
                    foreach (int[] direction in base.directions)
                    {
                        var point = new Point((int)(startX + dX) + direction[0],(int)(startY - dY) + direction[1]);
                        bmp.SetPixel(point, color);
                    }
                }

                startX += dX;
                startY -= dY;
            
                angle+=90;
            }
        }
    }
}