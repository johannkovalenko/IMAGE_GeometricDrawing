using System.Windows.Forms;
using System.Drawing;

namespace View
{
    public class FormConfig
    {
        public void Run(Form mainForm)
        {
            mainForm.Width = 1200;
            mainForm.Height = 760;
            mainForm.BackColor = Color.Beige;
        }
    }
}