using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Controller
{
    public class Controller
    {
        private Drawer drawer   = new Drawer();
        private View.MainForm mainForm;
        
        public void RunForm()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            mainForm = new View.MainForm(drawer);
            Application.Run(mainForm);
        }
    }
}