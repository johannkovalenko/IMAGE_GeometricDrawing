using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using JKDraw = JK.Tools.Drawing;

namespace Controller
{
    public class Controller
    {
        private JKDraw.BMP bmp = new JKDraw.BMPLockBits(1200, 760);
        private Drawer drawer;
        private View.MainForm mainForm;
        
        public Controller()
        {
            drawer = new Drawer(bmp);
        }
        public void RunForm()
        {
            drawer.Run();
            bmp.Save("output");

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            mainForm = new View.MainForm(drawer, bmp.Get());
            Application.Run(mainForm);
        }
    }
}