using System.Windows.Forms;
using System.Drawing;
using System;
using System.Collections.Generic;

namespace View
{
    public class MainForm : Form
    {
        Controller.Controller controller;
        PictureBox pb;

        public MainForm()
        {
            controller = new Controller.Controller(this);

            FormConfig();
            PictureBoxConfig();
            
            pb.Paint += delegate(object sender, PaintEventArgs e) { controller.Draw(e); };
        }

        public void Painter(PaintEventArgs e, Pixel pixel)
        {
            using (Pen pen = new Pen(pixel.color, 1)) 
            {
                e.Graphics.DrawRectangle(pen, new Rectangle(pixel.x, pixel.y, 1, 1));
            }
        }

        private void FormConfig()
        {
            this.Width = 600;
            this.Height = 600;
            this.BackColor = Color.Orange;
        }

        private void PictureBoxConfig()
        {
            pb = new PictureBox();
            pb.Location = new Point(0, 0);
            pb.Size = new Size(600, 600);
            
            Controls.Add(pb);
        }
    }
}