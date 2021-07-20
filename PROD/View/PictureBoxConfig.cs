using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class PictureBoxConfig
    {
        public void Run(PictureBox pb, Controller.Controller controller)
        {
            pb.Location = new Point(0, 0);
            pb.Size = new Size(600, 600);
            
            pb.Paint += delegate(object sender, PaintEventArgs e) { controller.Draw(e); };

        }
    }
}