using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace Controller
{
    public class Controller
    {
        private Model.IGeo geo = new Model.Circle();
        private View.Painter painter = new View.Painter();
       
        public void Draw(PaintEventArgs e)
        {
            List<Pixel> pixels = geo.Prepare(300, 300, Color.Red);

            foreach (Pixel pixel in pixels)
                painter.Run(e, pixel);
        }
    }
}