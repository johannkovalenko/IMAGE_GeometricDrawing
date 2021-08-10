using System.Drawing;
using System;
using JKDraw = JK.Tools.Drawing;

namespace Controller
{
    public class Drawer
    {
        private JKDraw.MagicFill magicFill = new JKDraw.MagicFill();

        private Model.IGeo[] geos = new Model.IGeo[] {new Model.Circle(), new Model.Square()}; 
        private int[] diameters = {30, 50, 70, 90, 110};
        private Color[] colors = 
        {
            Color.Red, Color.Brown, Color.Yellow, Color.Pink,
            Color.Blue, Color.Green, Color.LightBlue, Color.DarkBlue
        };

        public Bitmap Run()
        {
            JKDraw.BMP bmp = new JKDraw.BMPLockBits(1200, 760);
            magicFill.UpdateBMP(bmp);

            Random rnd    = new Random();

            for (int it=0; it<15; it++)
            {
                int figure      = rnd.Next(geos.Length);
                int diameter    = rnd.Next(diameters.Length);
                int color       = rnd.Next(colors.Length);
                int colorFill   = rnd.Next(colors.Length);
                int startX      = rnd.Next(50) * 20;
                int startY      = rnd.Next(30) * 20;
                int angle       = rnd.Next(90);

                var startPoint = new Point(startX, startY);
                geos[figure].Prepare(bmp, startPoint, Color.Gray, diameters[diameter], angle);
                magicFill.Run(startPoint, colors[colorFill]);
            }

            bmp.Save("output");

            return bmp.Get();
        }
    }
}