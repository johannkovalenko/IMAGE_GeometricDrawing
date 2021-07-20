using System.Drawing;
using System.Windows.Forms;
using System;

class DrawCircle
{
    private PaintEventArgs e;

    public DrawCircle(PaintEventArgs e)
    {
        this.e = e;
    }

    public void Run()
    {
        double dX, dY;
        Point cp = new Point();
        Random rnd;

        Color[] colors = new Color[] {
            Color.Pink, Color.Purple, Color.Red,
            Color.Green, Color.Blue, Color.Yellow,
            Color.Black, Color.Beige, Color.DarkBlue};

        for (int c=0;c<colors.Length;c++)
        {
            rnd = new Random();
            Point center = new Point(c*80, 50);
            
            using (Pen pen = new Pen(colors[c], 1)) 
            {
                for (double i=0;i<365;i++)
                {
                    dX = 30 * Math.Sin(i / 180 * Math.PI);
                    dY = 30 * Math.Cos(i / 180 * Math.PI);
                    cp.X = center.X + (int) dX;
                    cp.Y = center.Y - (int) dY;

                    e.Graphics.DrawRectangle(pen, new Rectangle(cp.X, cp.Y, 1, 1));
                }
            }
        }
    }
}