using System.Collections.Generic;
using System.Drawing;
using System;

namespace Model
{
    public class Circle : IGeo
    {
        public List<Pixel> Prepare(int startX, int startY, Color color, int length)
        {
            var output = new List<Pixel>();

            for (double i=0;i<365;i++)
            {
                double dX = length * Math.Sin(i / 180 * Math.PI);
                double dY = length * Math.Cos(i / 180 * Math.PI);
                
                output.Add(new Pixel(startX + (int) dX, startY - (int) dY, color));
            }

            return output;
        }
    }
}