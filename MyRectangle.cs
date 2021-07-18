using System.Drawing;
using System.Windows.Forms;
using System;

class MyRectangle
{
    private PaintEventArgs e;

    public MyRectangle(PaintEventArgs e)
    {
        this.e = e;
    }

    public void Run()
    {
        double dX = 0.0, dY = 0.0;
        double angle;
        DblPoint refPoint = new DblPoint();
        Point cp = new Point();

        Color[] colors = new Color[] 
        {
            Color.Pink, Color.Purple, Color.Red,
            Color.Green, Color.Blue, Color.Yellow,
            Color.Black, Color.Beige, Color.DarkBlue
        };

        for (int c=0;c<colors.Length;c++)
        {   
            angle = c * 10;
            refPoint.X = c * 50;
            refPoint.Y = 200;

            using (Pen pen = new Pen(colors[c], 1)) 
            {
                for (int i=0;i<4;i++)
                {
                    for (double j=1;j<=30;j++)
                    {
                        dX = j * Math.Sin(angle / 180 * Math.PI);
                        dY = j * Math.Cos(angle / 180 * Math.PI);
                        cp.X = (int)(refPoint.X + dX);
                        cp.Y = (int)(refPoint.Y - dY);

                        e.Graphics.DrawRectangle(pen, new Rectangle(cp.X, cp.Y, 1, 1));
                    }

                    refPoint.X = refPoint.X + dX;
                    refPoint.Y = refPoint.Y - dY;
                    angle += 90;
                }
            }
        }
    }

    class DblPoint
    {
        public double X;
        public double Y;
    }
}