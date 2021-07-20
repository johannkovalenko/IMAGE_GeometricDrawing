using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;

namespace View
{
    public class MainForm : Form
    {
        Controller.Controller controller = new Controller.Controller();
        Model.IGeo geo = new Model.Circle();

        PictureBox pb;

        public MainForm()
        {
            this.Width = 600;
            this.Height = 600;
            this.BackColor = Color.Orange;

            pb = new PictureBox();
            pb.Location = new Point(0, 0);
            pb.Size = new Size(600, 600);
            pb.Paint += new PaintEventHandler(PictureBox_Paint);
            Controls.Add(pb);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            List<Pixel> pixels = geo.Prepare(300, 300, Color.Red);

            foreach (Pixel pixel in pixels)
                using (Pen pen = new Pen(pixel.color, 1)) 
                {
                    e.Graphics.DrawRectangle(pen, new Rectangle(pixel.x, pixel.y, 1, 1));
                }
            //new DrawCircle(e).Run();
            //new MyRectangle(e).Run();
        }
    }
}