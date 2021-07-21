using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class MainForm : Form
    {
        private PictureBox pb = new PictureBox();
        private Button button = new Button();
        
        public MainForm(Controller.Drawer drawer, Bitmap bmp)
        {
            button.Text = "Create";

            button.Click += delegate(object sender, EventArgs e)
            {

            };
            new FormConfig().Run(this);
            new PictureBoxConfig().Run(pb);
            Controls.Add(pb);
            pb.Image = bmp;
            pb.Paint += delegate(object sender, PaintEventArgs e) 
            { 
                 
            };
            //pb.Refresh();
             
        }
    }
}