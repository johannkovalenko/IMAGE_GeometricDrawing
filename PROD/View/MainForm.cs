using System.Windows.Forms;
using JKDraw = JK.Tools.Drawing;

namespace View
{
    public class MainForm : Form
    {
        private PictureBox pb = new PictureBox();
        private JKDraw.BMP bmp = new JKDraw.BMPLockBits(1200, 760);

        public MainForm(Controller.Drawer drawer)
        {
            new FormConfig().Run(this);
            new PictureBoxConfig().Run(pb);
            pb.Paint += delegate(object sender, PaintEventArgs e) { drawer.Run(e); };
            pb.Refresh();
            Controls.Add(pb); 
        }

        public void SetEventHandler()
        {
 
        }
    }
}