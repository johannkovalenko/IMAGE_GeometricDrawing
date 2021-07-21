using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System;
using JKDraw = JK.Tools.Drawing;

namespace Controller
{
    public class Drawer
    {
        private JKDraw.BMP bmp;
        private JKDraw.MagicFill magicFill = new JKDraw.MagicFill();

        private View.Painter painter = new View.Painter();
        private Model.IGeo[] geos;
        private int[] diameters = {30, 50, 70, 90, 110};
        private Color[] colors = 
        {
            Color.Red, Color.Brown, Color.Yellow, Color.Pink,
            Color.Blue, Color.Green, Color.LightBlue, Color.DarkBlue
        };

        public Drawer(JKDraw.BMP bmp)
        {
            this.bmp = bmp;
            geos = new Model.IGeo[] {new Model.Circle(bmp), new Model.Square(bmp)};
            magicFill.UpdateBMP(bmp);
        }


        public void Run()
        {
            Random rnd    = new Random();

            for (int it=0; it<10; it++)
            {
                int figure      = rnd.Next(geos.Length);
                int diameter    = rnd.Next(diameters.Length);
                int color       = rnd.Next(colors.Length);
                int startX      = rnd.Next(50) * 20;
                int startY      = rnd.Next(30) * 20;

                geos[figure].Prepare(startX, startY, colors[color], diameters[diameter]);
                magicFill.Run(startX, startY, colors[color]);
            }

        }
    }
}