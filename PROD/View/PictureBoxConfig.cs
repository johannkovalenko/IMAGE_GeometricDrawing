using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class PictureBoxConfig
    {
        public void Run(PictureBox pb)
        {
            pb.Location = new Point(0, 0);
            pb.Size = new Size(1200, 760);
        }
    }
}