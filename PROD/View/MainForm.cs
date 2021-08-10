using System.Windows.Forms;
using System.Drawing;
using System;

namespace View
{
    public class MainForm : Form
    {
        private PictureBox pb = new PictureBox();
        private Button button = new Button();
        
        public MainForm(Controller.Drawer drawer)
        {
            FormConfig();
            ButtonConfig();
            PictureBoxConfig();

            button.Click += delegate(object sender, EventArgs e)
            {
                pb.Image = drawer.Run();
                pb.Refresh();
            };
            
            button.BringToFront();
        }

        private void ButtonConfig()
        {
            button.Text = "Create";
            button.Size = new Size(100, 50);
            button.Location = new Point(0,0);
            Controls.Add(button); 
        }

        private void FormConfig()
        {
            this.Width = 1200;
            this.Height = 760;
            this.BackColor = Color.Beige;
        }

        private void PictureBoxConfig()
        {
            pb.Location = new Point(0, 0);
            pb.Size = new Size(1200, 760);
            Controls.Add(pb);
        }
    }
}