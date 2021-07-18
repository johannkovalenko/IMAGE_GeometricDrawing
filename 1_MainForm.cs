using System.Windows.Forms;
using System.Drawing;
using System;

class MainForm : Form
{
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

    void PictureBox_Paint(object sender, PaintEventArgs e)
    {
        new DrawCircle(e).Run();
        new MyRectangle(e).Run();
    }
}