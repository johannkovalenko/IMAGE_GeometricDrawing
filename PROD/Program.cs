using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        new Controller.Controller().RunForm();      
    }
}
