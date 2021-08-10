using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace JK.Tools.Drawing
{
    public class BMPStandard : BMP 
    {
        private Bitmap bmp;

        public Bitmap Get()
        {
            return bmp;
        }

        public BMPStandard(string fileName)
        {
            bmp = new Bitmap(fileName);
        }

        public Color GetPixel(Point point)
        {
            return bmp.GetPixel(point.X, point.Y);
        }

        public void SetPixel(Point point, Color color)
        {
            bmp.SetPixel(point.X, point.Y, color);
        }

        public int TotalPixels()
        {
            return bmp.Width * bmp.Height;
        }

        public bool WithinBMP(Point point)
        {
            return (point.X < 0 || point.Y < 0 || point.X >= bmp.Width || point.Y >= bmp.Height) ? false : true;
        }

        public void Save(string file)
        {
            bmp.Save(@"..\output\" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
            bmp.Dispose();
        }
    }
}