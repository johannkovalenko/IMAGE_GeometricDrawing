using System.Collections.Generic;
using System.Drawing;
using System;

namespace Model
{
    public class Square : IGeo
    {
        public List<Pixel> Prepare(int startXInt, int startYInt, Color color, int length)
        {
            double startX = (double) startXInt - length/2;
            double startY = (double) startYInt + length/2;

            var output = new List<Pixel>();

            for (double angle=0; angle<360; angle+=90)
            {
                double dX = 0.0;
                double dY = 0.0;

                for (double j=1;j<=length;j++)
                {
                    dX = j * Math.Sin(angle / 180 * Math.PI);
                    dY = j * Math.Cos(angle / 180 * Math.PI);

                    output.Add(new Pixel((int)(startX + dX),(int)(startY - dY), Color.Green));
                }

                startX += dX;
                startY -= dY;
            }

            return output;
        }
    }
}