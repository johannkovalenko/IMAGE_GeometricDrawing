using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class Painter
    {
        public void Run(PaintEventArgs e, Pixel pixel)
        {
            using (Pen pen = new Pen(pixel.color, 1)) 
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(pixel.x, pixel.y, 1, 1));
            }
        }
    }
}