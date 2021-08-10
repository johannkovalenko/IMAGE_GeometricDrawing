using System.Drawing;

namespace JK.Tools.Drawing
{
    public interface BMP
    {
        Color GetPixel(Point point);
        void SetPixel(Point point, Color color);
        void Save(string file);
        Bitmap Get();
        bool WithinBMP(Point point);
        int TotalPixels();
    }
}