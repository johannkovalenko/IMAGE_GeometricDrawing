using System.Collections.Generic;
using System.Drawing;
using JKDraw = JK.Tools.Drawing;

namespace Model
{
    public abstract class IGeo
    {
        public abstract void Prepare(JKDraw.BMP bmp, Point startPoint, Color color, int length, int angle);

        protected int[][] directions = {
            new int[] {0, 0},
            new int[] {0, 1}, 
            new int[] {0, -1},
            new int[] {1, 0}, 
            new int[] {-1, 0}
        };
    }
}