using System.Windows.Forms;

namespace View
{
    public class MainForm : Form
    {
        private Controller.Controller controller = new Controller.Controller();
        private PictureBox pb = new PictureBox();

        public MainForm()
        {
            new FormConfig().Run(this);
            new PictureBoxConfig().Run(pb, controller);
            Controls.Add(pb);   
        }
    }
}