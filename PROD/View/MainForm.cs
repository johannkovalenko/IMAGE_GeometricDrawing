using System.Windows.Forms;

namespace View
{
    public class MainForm : Form
    {
        private PictureBox pb = new PictureBox();

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