using System.Collections.Generic;
using System.Drawing;
using System;
using JKDraw = JK.Tools.Drawing;

namespace Model
{
    public class Square : IGeo
    {
        private JKDraw.BMP bmp;
        
        public Square(JKDraw.BMP bmp)
        {
            this.bmp = bmp;
        }

        public void Prepare(int startXInt, int startYInt, Color color, int length)
        {
            double startX = (double) startXInt - length/2;
            double startY = (double) startYInt + length/2;

            for (double angle=0; angle<360; angle+=90)
            {
                double dX = 0.0;
                double dY = 0.0;

                for (double j=1;j<=length;j++)
                {
                    dX = j * Math.Sin(angle / 180 * Math.PI);
                    dY = j * Math.Cos(angle / 180 * Math.PI);

                    bmp.SetPixel((int)(startX + dX),(int)(startY - dY), color);
                }

                startX += dX;
                startY -= dY;
            }
        }
    }
}