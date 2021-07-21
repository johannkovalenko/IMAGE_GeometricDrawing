using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace JK.Tools.Drawing
{
    public class BMPStandard : BMP 
    {
        private Bitmap bmp;

        public BMPStandard(string fileName)
        {
            bmp = new Bitmap(fileName);
        }

        public Color GetPixel(int x, int y)
        {
            return bmp.GetPixel(x, y);
        }

        public void SetPixel(int x, int y, Color color)
        {
            bmp.SetPixel(x, y, color);
        }

        public void Save(string file)
        {
            bmp.Save(@"..\output\" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
            bmp.Dispose();
        }
    }
}