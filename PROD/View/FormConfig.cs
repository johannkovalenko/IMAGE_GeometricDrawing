using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class FormConfig
    {
        public void Run(Form mainForm)
        {
            mainForm.Width = 600;
            mainForm.Height = 600;
            mainForm.BackColor = Color.Orange;
        }
    }
}