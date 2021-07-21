using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System;

namespace JK.Tools.Drawing
{
    public class BMPLockBits : BMP 
    {
        private Bitmap bmp;
        private BitmapData bitmapData;
        private int bytesPerPixel;
        byte[] pixels;
        IntPtr ptrFirstPixel;
        
        public BMPLockBits(string fileName)
        {     
            bmp = new Bitmap(fileName);
            Init();
        }

        public BMPLockBits(int width, int height)
        {
            bmp = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bmp);
            graphics.FillRectangle(Brushes.White,0,0,width,height);
            Init();
        }

        private void Init()
        {
            bitmapData      = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, bmp.PixelFormat);      
            bytesPerPixel   = Bitmap.GetPixelFormatSize(bmp.PixelFormat) / 8;
            pixels          = new byte[bitmapData.Stride * bmp.Height];
            ptrFirstPixel   = bitmapData.Scan0;

            Marshal.Copy(ptrFirstPixel, pixels, 0, pixels.Length);
        }

        public Bitmap Get()
        {
            return bmp;
        }

        public Color GetPixel(int x, int y)
        {
            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return Color.Black;
                
            int line = y * bitmapData.Stride;
            int shift = x * bytesPerPixel;
        
            byte b  = pixels[line + shift];
            byte g  = pixels[line + shift + 1];
            byte r  = pixels[line + shift + 2]; 

            return Color.FromArgb(r, g, b);
        }

        public void SetPixel(int x, int y, Color color)
        {
            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return;
            
            int line = y * bitmapData.Stride;
            int shift = x * bytesPerPixel;
          
            pixels[line + shift]     = color.B;
            pixels[line + shift + 1] = color.G;
            pixels[line + shift + 2] = color.R;
        }

        public void Save(string file)
        {
            Marshal.Copy(pixels, 0, ptrFirstPixel, pixels.Length);
            bmp.UnlockBits(bitmapData);
            bmp.Save(@"..\output\" + Path.GetFileNameWithoutExtension(file) + ".png", ImageFormat.Png);
            //bmp.Dispose();
        }
    }
}