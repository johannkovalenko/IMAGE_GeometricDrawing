using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace Controller
{
    public class Drawer
    {
        private View.Painter painter = new View.Painter();
        private Model.IGeo[] geos  = {new Model.Circle(), new Model.Square()};
        private int[] diameters = {30, 50, 70, 90, 110};
        private Color[] colors = 
        {
            Color.Red, Color.Brown, Color.Yellow, Color.Pink,
            Color.Blue, Color.Green, Color.LightBlue, Color.DarkBlue
        };

        public void Run(PaintEventArgs e)
        {
            Random rnd    = new Random();

            for (int it=0; it<15; it++)
            {
                int figure      = rnd.Next(geos.Length);
                int diameter    = rnd.Next(diameters.Length);
                int color       = rnd.Next(colors.Length);
                int startX      = rnd.Next(50) * 20;
                int startY      = rnd.Next(30) * 20;

                List<Pixel> pixels = geos[figure].Prepare(startX, startY, colors[color], diameters[diameter]);

                foreach (Pixel pixel in pixels)
                    painter.Run(e, pixel);
            }

        }
    }
}